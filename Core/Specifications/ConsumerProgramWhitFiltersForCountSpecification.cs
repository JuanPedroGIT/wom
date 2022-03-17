using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ConsumerProgramWhitFiltersForCountSpecification : BaseSpecification<ConsumerProgram>
    {
        public ConsumerProgramWhitFiltersForCountSpecification(ConsumerProgramSpecParam cpParams)
        :base( x => (
                    (string.IsNullOrEmpty(cpParams.Search) || x.Consumer.Name.ToLower().Contains(cpParams.Search)) &&
            (cpParams.IdProgram == null || x.IdProgram == cpParams.IdProgram) && 
            (cpParams.IdStatus == null || x.IdStatus == cpParams.IdStatus) && 
            (cpParams.IdGeneration == null || x.IdGeneration == cpParams.IdGeneration) )
            )
        {
        }
    }
}