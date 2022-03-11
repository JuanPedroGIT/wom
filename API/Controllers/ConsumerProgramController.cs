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

    public class ConsumerProgramController : BaseController
    {
        private readonly IGenericRepository<ConsumerProgram> _genericRepo;
        private readonly IMapper _mapper;

        public ConsumerProgramController(
            IGenericRepository<ConsumerProgram> genericRepo,
            IMapper mapper
            )
        {
            _genericRepo = genericRepo;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<ActionResult<List<ConsumerProgramDto>>> GetConsumerPrograms()
        {
            var spec = new ConsumerProgramSpecification();
            var consumerPrograms = await _genericRepo.ListAsync(spec);
            return Ok( consumerPrograms.Select( c =>  _mapper.Map<ConsumerProgram, ConsumerProgramDto>(c)));
        }

        [HttpGet("{IdConsumerProgram}")]
        public async Task<ActionResult<ConsumerProgramDto>> GetConsumerPrograms(int IdConsumerProgram)
        {
            var spec = new ConsumerProgramSpecification(x => x.Id == IdConsumerProgram);
            var consumerProgram = await _genericRepo.GetEntityWhithSpec(spec);
            return Ok(_mapper.Map<ConsumerProgram, ConsumerProgramDto>(consumerProgram));
        }
    }
}