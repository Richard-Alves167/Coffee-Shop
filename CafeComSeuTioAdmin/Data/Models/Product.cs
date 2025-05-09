using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeComSeuTioAdmin.Data
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(10,ErrorMessage = "Descrição muito pequena.")]
        public string Description { get; set; }

        [Required]
        [MaxLength(16, ErrorMessage = "Descrição muito grande.")]
        public string ShortDescription { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string ImageFile { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public string Category { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
