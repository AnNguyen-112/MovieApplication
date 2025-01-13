using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class Review
    {
        [Required]
        public int MovieId { get; set; }
        
        [Required]
        public int UserId {  get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Required]
        public decimal Rating { get; set; }

        
        [Required]
        public string ReviewText { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("MovieId")]

        public Movie Movie { get; set; }

    }
}
