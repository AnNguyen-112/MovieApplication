using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class MovieCast
    {
        
        [Required]
        public int CastId { get; set; }

        [Required]
        public string Character {  get; set; }

        [Required]
        public int MovieId { get; set; }

        
        public Cast Cast{ get; set; }

        

        public Movie Movie { get; set; }
    }
}
