using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products {
    public class ViewAllProductsModel : PageModel {
        [BindProperty]
        public IProductRepository _productRepository { get; set; }

        public List<Product> ListaProduto;
        public List<Product> ListaProdutoFiltrado;
        public List<Product> ListaProdutoDeletado;
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public string DescricaoProduto { get; set; }

        public ViewAllProductsModel(IProductRepository productRepository) {
            _productRepository = productRepository;
        }
        public void OnGet() {
            ListaProduto = _productRepository.GetAll();
            //ListaProdutoFiltrado = _productRepository.GetAllFilter();
            //ListaProdutoDeletado = _productRepository.GetAllDeleted();
        }

        public void OnPost() {
        }
    }
}
