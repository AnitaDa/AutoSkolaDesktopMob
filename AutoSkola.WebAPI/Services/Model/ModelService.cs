using AutoMapper;
using AutoSkola.Model;
using AutoSkola.WebAPI.Database;
using Microsoft.CodeAnalysis.Editing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Model
{
    public class ModelService:CRUDBaseService<MModel,object,object,object,Database.Model>
    {
        public ModelService(AutoSkolaContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
