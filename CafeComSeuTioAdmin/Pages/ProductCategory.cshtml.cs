using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeteriaKwai.Pages
{
    public class ProductCategoryModel : PageModel
    {
        public IProductRepository _productRepository;
        public ProductCategoryModel (IProductRepository productRepository) {
            _productRepository = productRepository;
        }
        [FromRoute]
        public string category { get; set; }
        public List<Product> listaCategoriaProductos { get; set; } = new List<Product>();
        public void OnGet()
        {
            listaCategoriaProductos = _productRepository.GetAllOneCategory(category);
        }
    }
}
