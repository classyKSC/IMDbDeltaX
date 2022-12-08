using System.ComponentModel.DataAnnotations;

namespace IMDbDeltaX.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string? ProducerName { get; set; }
        public string? Bio { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Company { get; set; }
        public string? Gender { get; set; }

        public ICollection<Movie>? Movies { get; set; }
    }
}
