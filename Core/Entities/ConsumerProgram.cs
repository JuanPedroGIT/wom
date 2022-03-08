using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ConsumerProgram : BaseEntity
    {
        
        public int IdConsumer { get; set; }
        public Consumer Consumer { get; set; }

        public int IdProgram { get; set; }
        public Program Program { get; set; }
        public int IdGeneration { get; set; }
        public Generation Generation { get; set; }
        public int IdStatus { get; set; }
        public Status Status { get; set; }
        public string ActivationCode { get; set; }
        public int? IdConsumerProgramReference { get; set; }
        public int IdSource { get; set; }
        public Source Source { get; set; }
        public DateTime RecordDate{ get; set; }
    }
}