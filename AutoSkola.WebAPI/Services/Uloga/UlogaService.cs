using AutoMapper;
using AutoSkola.Model;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Uloga
{
    public class UlogaService:BaseService<MUloga,object,Database.Uloga>
    {
        public UlogaService(AutoSkolaContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
