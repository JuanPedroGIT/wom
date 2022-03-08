using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dto;
using AutoMapper;
using Core.Entities;

namespace API.Helppers
{
    public class MappingPorfiles : Profile
    {
        public MappingPorfiles()
        {
            //ConsumerProgram
            CreateMap<ConsumerProgram, ConsumerProgramDto>()
            .ForMember( d => d.Program, o => o.MapFrom(s => s.Program.ProgramName))
            .ForMember( d => d.IdConsumerProgram, o => o.MapFrom(s => s.Id))
            .ForMember( d => d.Consumer, o => o.MapFrom(s => s.Consumer.Name))
            .ForMember( d => d.Generation, o => o.MapFrom(s => s.Generation.GenerationName))
            .ForMember( d => d.Source, o => o.MapFrom(s => s.Source.SourceName))
            .ForMember( d => d.Status, o => o.MapFrom(s => s.Status.StatusName));

            //Consumer
            CreateMap<Consumer, ConsumerDto>()
                .ForMember(c => c.IdConsumer, o => o.MapFrom(s => s.Id))
                .ForMember(c => c.Floor, o => o.MapFrom<ConsumerResolver>());

            //Generation
            CreateMap<Generation, GenerationDto>()
                .ForMember(c => c.IdGeneration, o => o.MapFrom(s => s.Id));    

            //Program
            CreateMap<Core.Entities.Program, ProgramDto>()
                .ForMember(c => c.IdProgram, o => o.MapFrom(s => s.Id));        


            //Source
            CreateMap<Source, SourceDto>()
                .ForMember(c => c.IdSource, o => o.MapFrom(s => s.Id));

            //Status
            CreateMap<Status, StatusDto>()
                .ForMember(c => c.IdStatus, o => o.MapFrom(s => s.Id));
        }
    }
}