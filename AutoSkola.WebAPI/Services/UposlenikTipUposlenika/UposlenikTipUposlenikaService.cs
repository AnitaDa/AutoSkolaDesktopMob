using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.UposlenikTipUposlenika
{
    public class UposlenikTipUposlenikaService:CRUDBaseService<MUposlenikTipUposlenika,object,UTUUpsertRequest,object,Database.UposlenikTipUposlenika>
    {
        public UposlenikTipUposlenikaService(AutoSkolaContext context,IMapper mapper) : base(context, mapper)
        {

        }
    }
}
