using AutoMapper;
using AutoSkola.Model;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.LjekarskoUvjerenje
{
    public class LjekarskoUvjerenjeService:CRUDBaseService<MLjekarskoUvjerenje,object,object,object,Database.LjekarskoUvjerenje>
    {
        public LjekarskoUvjerenjeService(AutoSkolaContext context,IMapper mapper) : base(context, mapper)
        {

        }
    }
}
