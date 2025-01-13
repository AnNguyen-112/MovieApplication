using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class Genre
    {

        [Key]
        public int id { get; set; }


        [Required]
        public string Name { get; set; }

        
    }
}
