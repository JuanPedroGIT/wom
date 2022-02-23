using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class ConsumerController: ControllerBase
    {
        private readonly StoreContext _context;
        public ConsumerController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Consumer>>> GetConsumers(){
            var consumers = await _context.Consumers.ToListAsync();
            return Ok(consumers);
        }

        [HttpGet("{IdConsumer}")]
        public async Task<ActionResult<Consumer>> GetConsumer(int IdConsumer){
            var consumer = await _context.Consumers.FindAsync(IdConsumer);
            return Ok(consumer);
        }
    }
}