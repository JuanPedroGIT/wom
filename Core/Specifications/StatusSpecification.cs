using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class StatusSpecification : BaseSpecification<Status>
    {
        public StatusSpecification()
        {
        }

        public StatusSpecification(int id) : base(x => x.Id == id )
        {
        }
    }
}