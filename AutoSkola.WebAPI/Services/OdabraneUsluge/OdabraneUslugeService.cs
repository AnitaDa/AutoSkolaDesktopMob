using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.OdabraneUsluge
{
    public class OdabraneUslugeService:CRUDBaseService<MOdabraneUsluge,object,OdabraneUslugeUspertRequest,object,Database.OdabranaUsluga>
    {
        public OdabraneUslugeService(AutoSkolaContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
