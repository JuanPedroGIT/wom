using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dto;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class SourceController : ControllerBase
    {
        private readonly IGenericRepository<Source> _sourceRepo;
        private readonly IMapper _mapper;

        public SourceController(
            IGenericRepository<Source> sourceRepo,
            IMapper mapper)
        {
            _mapper = mapper;
            _sourceRepo = sourceRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Source>>> GetSources()
        {
            var spec = new SourceSpecification();
            var sources = await _sourceRepo.ListAsync(spec);
            return Ok(sources.Select(s =>  _mapper.Map<Source, SourceDto>(s)));
        }

        [HttpGet("{IdSource}")]
        public async Task<ActionResult<Source>> GetSource(int IdSource)
        {
            var spec = new SourceSpecification( x => x.Id == IdSource);
            var source = await _sourceRepo.GetEntityWhithSpec(spec);
            return Ok(_mapper.Map<Source, SourceDto>(source));
        }
    }
}