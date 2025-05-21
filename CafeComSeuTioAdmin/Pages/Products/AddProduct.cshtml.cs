using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products
{
    public class AddProductModel : PageModel
    {
        private CafeContext cafeContext;

        private IWebHostEnvironment webEnv;

        [BindProperty]
        public Product newProduct { get; set; }

        public AddProductModel(CafeContext context, IWebHostEnvironment webEnv) {
            this.cafeContext = context;
            this.webEnv = webEnv;
        }

        public void OnGet() {
        }

        public async Task<IActionResult> OnPost() {
            if (ModelState.IsValid) {
                if (newProduct.Upload is not null) {
                    newProduct.ImageFileName = newProduct.Upload.FileName;
                    var file = Path.Combine(webEnv.ContentRootPath, "wwwroot/images/menu", newProduct.ImageFileName);

                    using (var fileStream = new FileStream(file, FileMode.Create)) {
                        await newProduct.Upload.CopyToAsync(fileStream);
                    }
                }
                cafeContext.Add<Product>(newProduct);
                cafeContext.SaveChanges();
            }

            return RedirectToPage("ViewAllProducts",new { id = newProduct.Id });
        }
    }
}
