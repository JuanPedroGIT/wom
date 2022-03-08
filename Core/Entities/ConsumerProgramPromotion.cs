using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ConsumerProgramPromotion : BaseEntity
    {
        public int IdConsumerProgram { get; set; }
        public ConsumerProgram ConsumerProgram { get; set; }
        public int IdProgramPromotion { get; set; }
        public ProgramPromotion ProgramPromotion { get; set; }
        public string Answer { get; set; }
        public int IdStatus { get; set; }
        public Status Status { get; set; }
        public DateTime RecordDate{ get; set; }
        
    }
}