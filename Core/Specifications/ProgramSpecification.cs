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
        public ProgramSpecification(string sort)
        {
            AddInclude(x => x.ProgramQuestions);

             if(!string.IsNullOrEmpty(sort))
            {
                switch(sort)
                {
                    case "idAsc":
                        AddOrderBy(x => x.ProgramName);
                        break;
                    case "idDesc":
                        AddOrderByDescendidng(x => x.ProgramName);
                        break;
                    default:
                        AddOrderBy(x => x.Id);
                        break;         
                }
            }
        }

        public ProgramSpecification(Expression<Func<Program, bool>> criteria) : base(criteria)
        {
            AddInclude(x => x.ProgramQuestions);
        }
    }
}