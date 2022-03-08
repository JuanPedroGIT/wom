using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ProgramGenerationPeriod : BaseEntity
    {
         public int IdProgram { get; set; }
         public Program Program { get; set; }
        public int IdGeneration { get; set; }
        public Generation Generation { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string TrafficSource { get; set; }
        public int? MaximumReferencedConsumers { get; set; }
        
    }
}