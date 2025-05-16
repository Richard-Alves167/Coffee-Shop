using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CafeComSeuTioAdmin.Data;

namespace CafeteriaKwai.Data.Models {
    public class ProductDetail {
        [Key]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public string TechnicalSpecs { get; set; }

        public bool IsLimitedEdition { get; set; }

        public DateTime LaunchDate { get; set; }

        public Product Product { get; set; }

    }
}
