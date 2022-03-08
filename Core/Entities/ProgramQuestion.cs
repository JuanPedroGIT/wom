using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ProgramQuestion : BaseEntity
    {
        public int IdProgram { get; set; }
        public Program Program { get; set; }
        public string Question { get; set; }
    }
}