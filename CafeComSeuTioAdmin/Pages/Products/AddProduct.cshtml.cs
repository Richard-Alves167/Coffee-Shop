using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeComSeuTioAdmin.Pages.Products
{
    [Authorize]
    public class AddProductModel : PageModel
    {
        //private CafeContext cafeContext;

        private IWebHostEnvironment webEnv;
        private IProductRepository _productRepository;

        [BindProperty]
        public Product newProduct { get; set; }

        public List<Product> Products { get; set; }

        public AddProductModel(IProductRepository Irepository, IWebHostEnvironment webEnv) {
            //this.cafeContext = context;
            _productRepository = Irepository;
            this.webEnv = webEnv;
        }

        public void OnGet() {
            Products = _productRepository.GetAll();
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
                //cafeContext.Add<Product>(newProduct);
                // cafeContext.SaveChanges();
                _productRepository.Add(newProduct);
            }

            return RedirectToPage("ViewAllProducts",new { id = newProduct.Id });
        }
    }
}
