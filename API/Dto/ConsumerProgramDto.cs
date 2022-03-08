using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dto
{
    public class ConsumerProgramDto
    {
        public int IdConsumerProgram { get; set; }
        public string Consumer { get; set; }
        public string Program { get; set; }
        public string Generation { get; set; }
        public string Status { get; set; }
        public string ActivationCode { get; set; }
        public int? IdConsumerProgramReference { get; set; }
        public string Source { get; set; }
        public DateTime RecordDate{ get; set; }
    }
}