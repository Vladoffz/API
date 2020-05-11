using System.ComponentModel.DataAnnotations;

namespace FootballManager.Entities
{
     public class Championship
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
