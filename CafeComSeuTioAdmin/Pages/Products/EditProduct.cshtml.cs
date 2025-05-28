using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeteriaKwai.Pages.Products
{
    public class EditProductModel : PageModel
    {
        //private CafeContext cafeContext;

        private IWebHostEnvironment webEnv;
        private IProductRepository _productRepository;

        [BindProperty]
        public Product editProduct { get; set; }
        
        //[FromRoute]
        public int id;

        public List<Product> Products { get; set; }

        public EditProductModel(IProductRepository Irepository, IWebHostEnvironment webEnv) {
            //this.cafeContext = context;
            _productRepository = Irepository;
            this.webEnv = webEnv;
        }

        public void OnGet() {
            Products = _productRepository.GetAll();
        }

        public async Task<IActionResult> OnPost() {
            if (ModelState.IsValid) {
                if (editProduct.Upload is not null) {
                    editProduct.ImageFileName = editProduct.Upload.FileName;
                    var file = Path.Combine(webEnv.ContentRootPath, "wwwroot/images/menu", editProduct.ImageFileName);

                    using (var fileStream = new FileStream(file, FileMode.Create)) {
                        await editProduct.Upload.CopyToAsync(fileStream);
                    }
                }
                //cafeContext.Add<Product>(editProduct);
                // cafeContext.SaveChanges();
                _productRepository.Add(editProduct);
            }

            return RedirectToPage("ViewAllProducts", new { id = editProduct.Id });
        }
    }
}
