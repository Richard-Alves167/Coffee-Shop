using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeteriaKwai.Pages
{
    public class ProductDetailsClientModel : PageModel
    {
        public CafeContext cafeContext;

        IProductRepository _productRepository;

        [FromRoute]
        public int id { get; set; }

        public Product selectProduct { get; set; }

        public ProductDetailsClientModel(IProductRepository productRepository) {
            _productRepository = productRepository;
        }
        public void OnGet() {
            selectProduct = _productRepository.GetById(id);
        }
    }
}
