using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class GenerationController : ControllerBase
    {
        private readonly IGenericRepository<Generation> _genericRepo;
        public GenerationController(IGenericRepository<Generation> genericRepo)
        {
            _genericRepo = genericRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Generation>>> GetGenerations()
        {

            var spec = new GenerationSpecification();
            var generations = await _genericRepo.ListAsync(spec);
            return Ok(generations);
        }

        [HttpGet("{IdGeneration}")]
        public async Task<ActionResult<Generation>> GetGeneration(int IdGeneration)
        {
            var spec = new GenerationSpecification(IdGeneration);
            var generation = await _genericRepo.GetEntityWhithSpec(spec);
            return Ok(generation);
        }


    }
}