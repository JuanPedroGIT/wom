using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class SourceSpecification : BaseSpecification<Source>
    {
        public SourceSpecification()
        {
            //no hay ningún Addinclude
        }

        public SourceSpecification(Expression<Func<Source, bool>> criteria) : base(criteria)
        {

        }
    }
}