using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballManager.Entities
{
    public class Command
    {
        [Key]
        public int CommandID { get; set; }
        [Required]
        public int PlayerID { get; set; }
        [ForeignKey(nameof(PlayerID))]
        public string Country { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
