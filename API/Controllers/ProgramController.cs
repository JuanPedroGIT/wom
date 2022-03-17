using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Dto;
using AutoMapper;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Programm =Core.Entities.Program;

namespace API.Controllers
{

    public class ProgramController : BaseController
    {
        private readonly IGenericRepository<Programm> _programRepo;
        private readonly IMapper _mapper;

        public ProgramController(
            IGenericRepository<Programm> programRepo,
            IMapper mapper)
        {
            _programRepo = programRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProgramDto>>> GetPrograms(string sort)
        {

            var spec = new ProgramSpecification(sort);
            var programs = await _programRepo.ListAsync(spec);
            return Ok(programs.Select(p => _mapper.Map<Programm, ProgramDto>(p)));
        }

        [HttpGet("{IdProgram}")]
        public async Task<ActionResult<Programm>> GetProgram(int IdProgram)
        {
            var spec = new ProgramSpecification( x =>x.Id == IdProgram);
            var program = await _programRepo.GetEntityWhithSpec(spec);
            return Ok(_mapper.Map<Programm, ProgramDto>(program));
        }


    }
}