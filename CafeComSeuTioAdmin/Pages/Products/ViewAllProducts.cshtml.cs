using CafeComSeuTioAdmin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products
{
    public class ViewAllProductsModel : PageModel
    {
        public List<Product> ListaProduto;
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public void OnGet()
        {
            Product produto = new Product();
            ListaProduto = produto.ListaProdutos();
        }

        public void OnPost() {
        }
    }
}
