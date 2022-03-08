using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ConsumerProgramAnswer : BaseEntity
    {
        public int IdConsumerProgram { get; set; }
        public ConsumerProgram ConsumerProgram { get; set; }
        public int IdProgramQuestion { get; set; }
        public ProgramQuestion ProgramQuestion { get; set; }
        public string Answer { get; set; }
        public DateTime RecordDate{ get; set; }
    }
}