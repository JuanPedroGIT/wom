using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class ConsumerController: ControllerBase
    {
        private readonly IConsumerRepository _repo;

        public ConsumerController(IConsumerRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public async Task<ActionResult<List<Consumer>>> GetConsumers(){
            var consumers = await _repo.GetConsumersAsync();
            return Ok(consumers);
        }

        [HttpGet("{IdConsumer}")]
        public async Task<ActionResult<Consumer>> GetConsumer(int IdConsumer){
            var consumer = await _repo.GetConsumerByIdAsync(IdConsumer);
            return Ok(consumer);
        }
    }
}