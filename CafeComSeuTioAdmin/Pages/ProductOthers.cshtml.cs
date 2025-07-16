using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeteriaKwai.Pages
{
    public class ProductOthersModel : PageModel
    {
        public IProductRepository ProductRepository { get; }
        public ProductOthersModel (IProductRepository productRepository) {
            ProductRepository = productRepository;
        }

        [FromRoute]
        public string StringSearch { get; set; } = string.Empty;
        public List<Product> ListaProdutosPesquisados { get; set; } = new List<Product>();
        public void OnGet()
        {
            if (string.IsNullOrEmpty(StringSearch)) {
                ListaProdutosPesquisados = ProductRepository.GetAllLastLimitSelected(6);
            } else {
                ListaProdutosPesquisados = ProductRepository.GetSearchLimitSelected(StringSearch, 6);
            }
        }
        public async Task<IActionResult> OnPost() {
            return RedirectToPage("ProductOthers");
        }
    }
}
