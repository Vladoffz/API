using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballManager.Entities
{
    public class ChampionshipCommand
    {
        [Key]
        public int ChampionshipCommandID { get; set; }
        [Required]
        public int ChampionshipID { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("ChampionshipID")]
        public int CommandID { get; set; }
        [ForeignKey("CommandID")]

        public Command Command { get; set; }
        public Championship Championship { get; set; }
        public IEnumerable<Championship> Championships { get; set; }
        public IEnumerable<Command> Commands { get; set; }
    }
}
