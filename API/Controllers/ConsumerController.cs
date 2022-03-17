using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Core.Specifications;
using AutoMapper;
using API.Dto;
using API.Errors;

namespace API.Controllers
{

    public class ConsumerController: BaseController
    {
      
        private readonly IGenericRepository<Consumer> _consumerRepo;
        private readonly IMapper _mapper;

        public ConsumerController(
            IGenericRepository<Consumer> consumerRepo,
            IMapper mapper)
        {
            _mapper = mapper;
            _consumerRepo = consumerRepo;
           
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ConsumerDto>>> GetConsumers(string sort)
        {

            var spec = new ConsumerSpecification(sort);
            var consumers = await _consumerRepo.ListAsync(spec);
            return Ok(_mapper.Map<IReadOnlyList<Consumer>,IReadOnlyList<ConsumerDto>>(consumers));
        }

        [HttpGet("{IdConsumer}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Consumer>> GetConsumer(int IdConsumer)
        {
            var spec = new ConsumerSpecification(IdConsumer);
            var consumer = await _consumerRepo.GetEntityWhithSpec(spec);

            if(consumer == null ) return NotFound(new ApiResponse(404));
            
            return Ok(_mapper.Map<Consumer, ConsumerDto>(consumer));
        }
    }
}