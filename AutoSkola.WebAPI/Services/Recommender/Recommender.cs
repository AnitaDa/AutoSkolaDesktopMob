using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Recommender
{
    public class Recommender
    {
        private Dictionary<int, List<Utisak>> utisciZaDrugeInstruktore = new Dictionary<int, List<Utisak>>();
        private readonly AutoSkolaContext _context;

        private readonly IMapper _mapper;
        public Recommender(AutoSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<MUposlenik> GetSlicniInstruktori(RecommenderSearchRequest search)
        
            {
            UcitajInstruktore(search.InstruktorId);//svi osim odabranog
            var utisciOdabranogInstruktora = _context.Utisak.Where(x => x.UposlenikId == search.InstruktorId).OrderBy(x => x.KandidatId).ToList();
            var zajednickeOcene1 = new List<Utisak>();
            var zajednickeOcene2 = new List<Utisak>();
            var slicniInstruktori = new List<MUposlenik>();
            foreach (var inst in utisciZaDrugeInstruktore)
            {
                foreach (var utisci in utisciOdabranogInstruktora)
                {
                    if (inst.Value.Where(x => x.KandidatId == utisci.KandidatId).Count() > 0)
                    {
                        zajednickeOcene1.Add(utisci);
                        zajednickeOcene2.Add(inst.Value.Where(x => x.KandidatId == utisci.KandidatId).First());
                    }
                }
                double slicnost = GetSlicnost(zajednickeOcene1, zajednickeOcene2);
                var slicanInstruktor = InstruktorGetById(inst.Key);
                if (slicnost > 0.6)
                    slicniInstruktori.Add(slicanInstruktor);
                zajednickeOcene1.Clear();
                zajednickeOcene2.Clear();

            }
            return slicniInstruktori;
        }
        private double GetSlicnost(List<Utisak> zajednickeOcjene1, List<Utisak> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;
            double broilac = 0, imenilac1 = 0, imenilac2 = 0;
            for(int i = 0; i < zajednickeOcjene2.Count; i++)
            {
                broilac+= (double)zajednickeOcjene1[i].Ocjena * (double)zajednickeOcjene2[i].Ocjena;
                imenilac1+= (double)zajednickeOcjene1[i].Ocjena * (double)zajednickeOcjene1[i].Ocjena;
                imenilac2+= (double)zajednickeOcjene2[i].Ocjena * (double)zajednickeOcjene2[i].Ocjena;
            }
            imenilac1 = Math.Sqrt(imenilac1);
            imenilac2 = Math.Sqrt(imenilac2);
            double imenilac = imenilac1 * imenilac2;
            if (imenilac == 0)
                return 0;
            return broilac / imenilac;

        }
        private void UcitajInstruktore(int instruktorId)
        {
            var ostaliInstruktori = GetUposleniciTipaInstruktor(instruktorId);
            var utisci = new List<Utisak>();
            foreach (var i in ostaliInstruktori)
            {
                utisci = _context.Utisak.Where(x => x.UposlenikId == i.Id).OrderBy(x => x.KandidatId).ToList();
                if (utisci.Count > 0)
                    utisciZaDrugeInstruktore.Add(i.Id, utisci);
            }
        }
        public List<MUposlenik> GetUposleniciTipaInstruktor(int instruktorId)
        {
            var instruktori = _context.UposlenikTipUposlenika.Where(x => x.TipUposlenika.Naziv == "Instruktor" && x.UposlenikId != instruktorId).Select(x => new MUposlenik
            {
                Id = x.UposlenikId,
                ImePrezime = x.Uposlenik.Ime + " " + x.Uposlenik.Prezime,
                DatumRodjenja = x.Uposlenik.DatumRodjenja,
                Slika = x.Uposlenik.Slika,
                TipUposlenika = x.TipUposlenika.Naziv
            }).ToList();

            return _mapper.Map<List<MUposlenik>>(instruktori);

        }
        public MUposlenik InstruktorGetById(int instruktorId)
        {
            var instruktor = _context.Uposlenik.Find(instruktorId);
            return _mapper.Map<MUposlenik>(instruktor);
        }
    }
}