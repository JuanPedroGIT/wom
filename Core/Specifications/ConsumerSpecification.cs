using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ConsumerSpecification : BaseSpecification<Consumer>
    {
        public ConsumerSpecification(string sort)
        {
            //AddInclude(x => )
            AddOrderBy(x => x.Id);
            if(!string.IsNullOrEmpty(sort))
            {
                switch(sort)
                {
                    case "nameAsc":
                        AddOrderBy(n => n.Name);
                        break;
                    case "nameDesc":
                        AddOrderByDescendidng(n => n.Name);
                        break;
                    default :  
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public ConsumerSpecification(int id) : base(x => x.Id == id )
        {
             //AddInclude(x => )
        }
    }
}