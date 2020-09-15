using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Kategorije
{
    public class KategorijeService:CRUDBaseService<MKategorije,object, KategorijeUpsertRequest, KategorijeUpsertRequest, Database.Kategorija>
    {
        public KategorijeService(AutoSkolaContext context,IMapper mapper) : base(context, mapper)
        {

        }

        //override delete
        //prvo brises ove podatke koji su vezani za kategorijuID tu
        //tek na kraju kategoriju
        //mogu li samo baciti ex da se koristi podatak u drugim tabelama
        //gde cu to sve raditi, meni svaka tabela vezana za nesto, ne bih do prekosutra

        
    }
}
