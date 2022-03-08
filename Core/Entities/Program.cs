using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Program : BaseEntity
    {
        public string ProgramName { get; set; }


        public List<ProgramQuestion> ProgramQuestions { get; set; }
        
        // override
        // public string ToString(){
        //     return ProgramName;
        // }
    }
}