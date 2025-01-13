using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class Purchase
    {
        [Required]
        public int MovieId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime PurchaseDateTime { get; set; }

        [Required]
        public string PurchaseNumber { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }


        

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

    }
}
