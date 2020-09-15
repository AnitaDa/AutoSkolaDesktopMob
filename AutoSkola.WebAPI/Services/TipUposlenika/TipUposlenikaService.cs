using AutoMapper;
using AutoSkola.Model;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.TipUposlenika
{
    public class TipUposlenikaService:BaseService<MTipUposlenika,object,Database.TipUposlenika>
    {
        public TipUposlenikaService(AutoSkolaContext context,IMapper mapper) : base(context, mapper)
        {

        }
    }
}
