using System.ComponentModel.DataAnnotations;

namespace IMDbDeltaX.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string? ActorName { get; set; }
        public string? Bio { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Gender { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
