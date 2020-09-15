using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Usluge
{
    public class UslugaZahtjevService : CRUDBaseService<MUsluge, ZahtjeviSearchRequest, ZahtjeviUpsertRequest, ZahtjeviUpsertRequest, Usluga>
    {
        public UslugaZahtjevService(AutoSkolaContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
