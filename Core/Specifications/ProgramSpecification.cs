using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProgramSpecification : BaseSpecification<Program>
    {
        public ProgramSpecification()
        {
            AddInclude(x => x.ProgramQuestions);
        }

        public ProgramSpecification(Expression<Func<Program, bool>> criteria) : base(criteria)
        {
            AddInclude(x => x.ProgramQuestions);
        }
    }
}