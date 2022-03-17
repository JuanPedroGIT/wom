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
        public ConsumerProgramSpecification(ConsumerProgramSpecParam cpParams, bool forCount = false)
        :base( x => (
            (string.IsNullOrEmpty(cpParams.Search) || x.Consumer.Name.ToLower().Contains(cpParams.Search)) &&
            (cpParams.IdProgram == null || x.IdProgram == cpParams.IdProgram) &&
            (cpParams.IdStatus == null || x.IdStatus == cpParams.IdStatus) &&
            (cpParams.IdGeneration == null || x.IdGeneration == cpParams.IdGeneration) 
        ) )
        {
            if(!forCount)
            {
                AddInclude(x => x.Generation);
                AddInclude(x => x.Program);
                AddInclude(x => x.Consumer);
                AddInclude(x => x.Status);
                ApplyPaging(cpParams.PageSize * (cpParams.PageIndex -1), cpParams.PageSize);    


                if(!string.IsNullOrEmpty(cpParams.Sort))
                {
                    switch(cpParams.Sort)
                    {
                        case "idAsc":
                            AddOrderBy(x => x.IdConsumer);
                            break;
                        case "idDesc":
                            AddOrderByDescendidng(x => x.IdConsumer);
                            break;
                        default:
                            AddOrderBy(x => x.IdConsumer);
                            break;         
                    }
                }
            }
            
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