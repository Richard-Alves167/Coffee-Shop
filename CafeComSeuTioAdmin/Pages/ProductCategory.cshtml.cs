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
        public List<Product> listaCategoriaProdutos { get; set; } = new List<Product>();
        public Product lastProduct { get; set; } = new Product();
        public decimal priceDiscounted { get; set; } = 0;
        public void OnGet()
        {
            listaCategoriaProdutos = _productRepository.GetAllOneCategoryLimitSelected(category, 5);
            lastProduct = _productRepository.GetLastOneCategory(category);
            priceDiscounted = Math.Round(lastProduct.Price - (lastProduct.Price * 0.1m),2);
        }
    }
}
