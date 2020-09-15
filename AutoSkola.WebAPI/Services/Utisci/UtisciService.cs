using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Utisci
{
    public class UtisciService:CRUDBaseService<MUtisak, UtisakSearchRequest,UtisakUpsertRequest,object,Database.Utisak>
    {
        public UtisciService(AutoSkolaContext context, IMapper mapper) : base(context, mapper) { 

        }
    }
}
