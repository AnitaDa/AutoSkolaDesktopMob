using AutoMapper;
using AutoSkola.Model;
using AutoSkola.WebAPI.Database;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Marka
{
    public class MarkaService:CRUDBaseService<MMarka,object,object,object,Database.Marka>
    {
        public MarkaService(AutoSkolaContext context,IMapper mapper) : base(context,mapper)
        {

        }
    }
}
