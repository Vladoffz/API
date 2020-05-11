using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballManager.Entities
{
    public class Player
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Command { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
