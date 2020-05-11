using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class PlayerDTO
    {
        public int ID { get; set; }
     
        public int Age { get; set; }
    
        public string LastName { get; set; }
       
        public string FirstName { get; set; }

        public string Command { get; set; }

        public List<PlayerDTO> Players { get; set; }
    }
}
