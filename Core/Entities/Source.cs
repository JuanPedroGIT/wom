using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Source : BaseEntity
    {
        public string SourceName { get; set; }
        public string SourceCripto { get; set; }
    }
}