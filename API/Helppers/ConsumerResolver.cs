using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dto;
using AutoMapper;
using Core.Entities;

namespace API.Helppers
{
    public class ConsumerResolver : IValueResolver<Consumer, ConsumerDto, string>
    {
        private readonly IConfiguration _config;
        public ConsumerResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Consumer source, ConsumerDto destination, string destMember, ResolutionContext context)
        {
            if(string.IsNullOrEmpty(source.Floor))
            {
                return _config["ApiUrl"]+"Relolver";
            }
            return source.Floor;
            
        }
    }
}