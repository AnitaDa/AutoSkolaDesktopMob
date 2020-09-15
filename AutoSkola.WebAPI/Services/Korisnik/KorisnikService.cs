using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Korisnik
{
    public class KorisnikService:IKorisniciService
    {
        private readonly AutoSkolaContext _context;
        private readonly IMapper _mapper;
        public KorisnikService(AutoSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string lozinka)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(lozinka);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public  MKorisnik Insert(KorisnikUpsertRequest insert)
        {
            //provera tacnosti lozinke
            if (insert.Lozinka != insert.PotrvrdnaLozinka)
            {
                throw new Exception("Lozinke se ne slazu!");
            }
            var entity = _mapper.Map<Database.Korisnik>(insert);
            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt,insert.Lozinka);
            _context.Korisnik.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<MKorisnik>(entity);
        }



        public MKorisnik Update(int id, KorisnikUpsertRequest request)
        {
            var entity = _context.Korisnik.Find(id);
            //proveravamo da li je ista unesena stara lozinka sa postojecom u bazi, ako jeste, omogucava 
            var unetastaraLozinkaHash = GenerateHash(entity.LozinkaSalt, request.StaraLozinka);
            if (unetastaraLozinkaHash == entity.LozinkaHash)
            {
                if (!string.IsNullOrWhiteSpace(request.Lozinka))
                {
                    entity.LozinkaSalt = GenerateSalt();

                    entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
                    _context.SaveChanges();
                }
            }         
            _mapper.Map(request, entity);
            _context.SaveChanges();
            //prebaciti na login
            return _mapper.Map<MKorisnik>(entity);

        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<MKorisnik> Get(KorisniciSearchRequest search)
        {
            var query = _context.Korisnik.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                query = query.Where(d => d.KorisnickoIme == search.KorisnickoIme);
            }
            var list = query.ToList();
            return _mapper.Map<List<MKorisnik>>(list);
        }

        public MKorisnik GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public MKorisnik Authenticate(AuthenticateRequest request)
        {
            var user = _context.Korisnik
                .Include("KorisnikUloga.Uloga")
                .FirstOrDefault(x => x.KorisnickoIme == request.Username);

            if (user != null)
            {
                var hash = GenerateHash(user.LozinkaSalt, request.Password);
                if (hash == user.LozinkaHash)
                {
                    return _mapper.Map<MKorisnik>(user);
                }
            }

            return null;
        }
    }
}
