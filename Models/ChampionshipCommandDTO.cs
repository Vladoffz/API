using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ChampionshipCommandDTO
    {
        public int ChampionshipCommandID { get; set; }
 
        public int ChampionshipID { get; set; }
      
        public string Name { get; set; }
      
        public int CommandID { get; set; }
        
        public CommandDTO Command { get; set; }
        public ChampionshipDTO Championship { get; set; }
        public List<ChampionshipDTO> Championships { get; set; }
        public List<CommandDTO> Commands { get; set; }
    }
}
