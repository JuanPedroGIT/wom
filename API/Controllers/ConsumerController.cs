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

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class ConsumerController: ControllerBase
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
        public async Task<ActionResult<IReadOnlyList<ConsumerDto>>> GetConsumers()
        {

            var spec = new ConsumerSpecification();
            var consumers = await _consumerRepo.ListAsync(spec);
            return Ok(_mapper.Map<IReadOnlyList<Consumer>,IReadOnlyList<ConsumerDto>>(consumers));
        }

        [HttpGet("{IdConsumer}")]
        public async Task<ActionResult<Consumer>> GetConsumer(int IdConsumer)
        {
            var spec = new ConsumerSpecification(IdConsumer);
            var consumer = await _consumerRepo.GetEntityWhithSpec(spec);
            return Ok(_mapper.Map<Consumer, ConsumerDto>(consumer));
        }
    }
}