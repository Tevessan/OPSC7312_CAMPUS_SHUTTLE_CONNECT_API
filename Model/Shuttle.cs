using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CampusShuttleAPI.Model
{
    public class Shuttle
    {
        [Key] 
        public int Id { get; set; }

        [Required]  
        [MaxLength(100)]  
        public string Destination { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }
    }
}
