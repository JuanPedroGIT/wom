using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ConsumerProgramSpecParam
    {
        private const int MaxPageSize = 50;
        public int PageIndex { get; set; } = 1;
        private int _pageSize = 6;
        public int PageSize 
        {
            get => _pageSize;
            set => _pageSize = (value>MaxPageSize) ? MaxPageSize : value;
        }
        public string Sort {get;}
        public int? IdProgram  {get;}
        public int? IdStatus {get;} 
        public int? IdGeneration  {get;}
        private string _search;
        public string Search 
        {
            get => _search;
            set => _search = value.ToLower();
        }
    }
}