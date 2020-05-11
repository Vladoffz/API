using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class CommandDTO
    {
        public int CommandID { get; set; }
  
        public int PlayerID { get; set; }
        
        public string Country { get; set; }
    
        public string Name { get; set; }

        public List<PlayerDTO> Players { get; set; }
    }
}
