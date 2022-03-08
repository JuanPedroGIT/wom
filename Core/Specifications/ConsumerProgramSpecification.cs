using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ConsumerProgramSpecification : BaseSpecification<ConsumerProgram>
    {
        public ConsumerProgramSpecification()
        {
            AddInclude(x => x.Generation);
            AddInclude(x => x.Program);
            AddInclude(x => x.Consumer);
            AddInclude(x => x.Status);

        }

        public ConsumerProgramSpecification(Expression<Func<ConsumerProgram, bool>> criteria) : base(criteria)
        {
            AddInclude(x => x.Generation);
            AddInclude(x => x.Program);
            AddInclude(x => x.Consumer);
            AddInclude(x => x.Status);

        }
    }
}