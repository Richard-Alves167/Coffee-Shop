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

        [BindProperty(SupportsGet = true)]
        public string ProductSearchCategory { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string ProductSearchSubCategory { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public decimal ProductSearchMinPrice { get; set; } = 0;

        [BindProperty(SupportsGet = true)]
        public decimal ProductSearchMaxPrice { get; set; } = 0;

        [BindProperty(SupportsGet = true)]
        public int ProductSearchAvaliation { get; set; } = 0;

        [FromRoute]
        public string StringSearch { get; set; } = string.Empty;
        public List<Product> ListaProdutosPesquisados { get; set; } = new List<Product>();
        public void OnGet() {
            if (string.IsNullOrEmpty(StringSearch)) {
                ListaProdutosPesquisados = ProductRepository.GetAllLastLimitSelected(9);
            }else {
                ListaProdutosPesquisados = ProductRepository.GetSearchLimitSelected(StringSearch, 9);
            }
        }
        public void OnPost() {
            ListaProdutosPesquisados = ProductRepository.GetSearchFilteredLimitSelected(StringSearch, 9, ProductSearchCategory, ProductSearchSubCategory, ProductSearchMinPrice, ProductSearchMaxPrice, ProductSearchAvaliation);
        }
        public void OnPostClean() {
            ProductSearchCategory = string.Empty;
            ProductSearchSubCategory = string.Empty;
            ProductSearchMinPrice = 0;
            ProductSearchMaxPrice = 0;
            ProductSearchAvaliation = 0;
            if (string.IsNullOrEmpty(StringSearch)) {
                ListaProdutosPesquisados = ProductRepository.GetAllLastLimitSelected(9);
            } else {
                ListaProdutosPesquisados = ProductRepository.GetSearchLimitSelected(StringSearch, 9);
            }
        }
    }
}
