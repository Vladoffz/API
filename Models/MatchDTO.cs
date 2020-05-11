using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class MatchDTO
    {
        public int MatchID { get; set; }

        public DateTime Date { get; set; }
    
        public int Result { get; set; }
      
        public int CommandID { get; set; }
        
        public List<CommandDTO> Commands { get; set; }
    }
}
