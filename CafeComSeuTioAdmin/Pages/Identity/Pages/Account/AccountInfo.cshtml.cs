using CafeteriaKwai.Data;
using CafeteriaKwai.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeteriaKwai.Pages.Identity.Pages.Account
{
    public class AccountInfoModel : PageModel
    {
        public IIdentityRepository identityRepository;

        public AccountInfoModel(IIdentityRepository identityRepository, IWebHostEnvironment webEnv) {
            this.identityRepository = identityRepository;
        }

        [BindProperty]
        public ApplicationUser user { get; set; }
        public void OnGet() {
        }
    }
}
