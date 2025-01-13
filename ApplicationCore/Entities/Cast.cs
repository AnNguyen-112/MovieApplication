using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class Cast
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        [Required]
        public string Gender { get; set; }

        [Column(TypeName = "nvarchar(128)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(2048)")]
        [Required]
        public string ProfilePath { get; set; }


        [Column(TypeName = "nvarchar(MAX)")]
        [Required]
        public string TmdbUrl { get; set; }
    }
}
