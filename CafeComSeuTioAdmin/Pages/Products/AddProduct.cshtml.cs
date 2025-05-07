using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public void OnGet() {
        }

        public void OnPost() {

        }
    }
}
