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
    public class StatusController : BaseController
    {
        private readonly IGenericRepository<Status> _statusRepo;
        private readonly IMapper _mapper;
        public StatusController(IGenericRepository<Status> statusRepo, IMapper mapper)
        {
            _mapper = mapper;
            _statusRepo = statusRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Status>>> GetStatues()
        {
            var spec = new StatusSpecification(); 
            var statues = await _statusRepo.ListAsync(spec);
            return Ok(statues.Select(s => _mapper.Map<Status,StatusDto>(s)));
        }

        [HttpGet("{IdStatus}")]
        public async Task<ActionResult<Status>> GetStats(int IdStatus)
        {
            var spec = new StatusSpecification(IdStatus); 
            var statue = await _statusRepo.GetEntityWhithSpec(spec);
            return Ok(_mapper.Map<Status,StatusDto>(statue));
        }

    }
}