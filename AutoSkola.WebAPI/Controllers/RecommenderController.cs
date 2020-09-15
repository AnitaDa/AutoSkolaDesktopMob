using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using AutoSkola.WebAPI.Services.Recommender;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Interfaces;
using Microsoft.VisualBasic.CompilerServices;

namespace AutoSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommenderController : ControllerBase
    {
        private AutoSkolaContext _context = new AutoSkolaContext();
        private readonly Recommender _recommenderService;
        private readonly IMapper _mapper;

        public RecommenderController(AutoSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _recommenderService = new Recommender(_context, _mapper);
        }
        [HttpGet]
        public List<MUposlenik> Get([FromQuery] RecommenderSearchRequest search)
        {
            return _recommenderService.GetSlicniInstruktori(search);
        }

    }
}
