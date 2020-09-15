using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.UslugeProdavnica
{
    public class UslugeProdavnicaService:CRUDBaseService<MUslugeProdavnica,object,UslugeProdavnicaUpsertRequest,object,Database.UslugeProdavnica>
    {
        public UslugeProdavnicaService(AutoSkolaContext context,IMapper mapper) : base(context, mapper)
        {

        }
    }
}
