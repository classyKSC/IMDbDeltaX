using System.ComponentModel.DataAnnotations;

namespace IMDbDeltaX.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string? MovieName { get; set;}
        public string? Plot { get; set;}
        public string? DateOfRelease { get; set;}
        public Producer? Producer { get; set;}
        public ICollection<Actor>? Actors { get; set;}
        public string? Poster { get; set;}

    }
}
