using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class Trailer
    {
        [Key]
        public int Id { get; set; }

        // Foreign Key to the Movie entity
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        
        public string Name { get; set; }

        
   
        public string TrailerUrl { get; set; }


    }
}
