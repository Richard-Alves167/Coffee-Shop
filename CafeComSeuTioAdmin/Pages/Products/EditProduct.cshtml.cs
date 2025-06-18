using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeteriaKwai.Pages.Products
{
    [Authorize]
    public class EditProductModel : PageModel
    {
        //private CafeContext cafeContext;

        private IWebHostEnvironment webEnv;
        private IProductRepository _productRepository;

        [BindProperty]
        public Product editProduct { get; set; }

        [FromRoute]
        public int id { get; set; }

        public List<Product> Products { get; set; }

        public EditProductModel(IProductRepository Irepository, IWebHostEnvironment webEnv) {
            //this.cafeContext = context;
            _productRepository = Irepository;
            this.webEnv = webEnv;
        }

        public void OnGet() {
            editProduct = _productRepository.GetById(id);
            Products = _productRepository.GetAll();
        }

        public async Task<IActionResult> OnPostEdit() {
            editProduct.Id = id;
            editProduct.Created = DateTime.Now;

            editProduct.Deleted = false;

            _productRepository.Update(editProduct);
            return RedirectToPage("ViewAllProducts", new { id = editProduct.Id });
        }
        public async Task<IActionResult> OnPostDelete() {
            _productRepository.LogicalDelete(id);
            return RedirectToPage("ViewAllProducts", new { id = editProduct.Id });
        }
    }
}
