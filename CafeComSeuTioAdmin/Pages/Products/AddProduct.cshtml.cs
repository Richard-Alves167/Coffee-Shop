using CafeComSeuTioAdmin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public Product newProduct { get; set; }
        public void OnGet() {
        }

        public void OnPost() {
            if (ModelState.IsValid) {
                var filename = $"Produtos.txt";
                var caminho = Path.Combine("wwwroot/files", filename);

                var productName = newProduct.Name;
                var productShortDescription = newProduct.ShortDescription;
                var productDescription = newProduct.Description;
                var productPrice = newProduct.Price;
                var productCategory = newProduct.Category;

                using (StreamWriter escrever = new StreamWriter(caminho, true)) {
                    escrever.WriteLine($"{productName},{productShortDescription},{productDescription},{productPrice},{productCategory}");
                    //escrever.WriteLine("Nome do Produto: " + productName);
                    //escrever.WriteLine("Descrição pequena do Produto: " + productShortDescription);
                    //escrever.WriteLine("Descrição do Produto: " + productDescription);
                    //escrever.WriteLine("Preço do Produto: " + productPrice);
                    //escrever.WriteLine("Categoria do Produto: " + productCategory);
                }
            }
        }
    }
}
