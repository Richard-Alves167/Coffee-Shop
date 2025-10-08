using System.Drawing;
using CafeteriaKwai.Data;
using CafeteriaKwai.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CafeteriaKwai.Pages.Identity.Pages.Account
{
    public class AccountInfoModel : PageModel
    {
        public IIdentityRepository identityRepository;
        private IWebHostEnvironment webEnv;
        private readonly UserManager<ApplicationUser> userManager;
        public AccountInfoModel(IIdentityRepository identityRepository, IWebHostEnvironment webEnv, UserManager<ApplicationUser> userManager) {
            this.identityRepository = identityRepository;
            this.webEnv = webEnv;
            this.userManager = userManager;
        }

        [BindProperty]
        public ApplicationUser user { get; set; }

        public void OnGet() {
        }

        public async Task<IActionResult> OnPostEdit() {
            ApplicationUser userSinged = await userManager.GetUserAsync(User);
            userSinged.UserImageFile = user.UserImageFile;
            string extensionFile = Path.GetExtension(user.UserImageFile.FileName).ToLower();

            if (ModelState.IsValid) {
                if (extensionFile == ".jpg" || extensionFile == ".jpeg" || extensionFile == ".webp" || extensionFile == ".png" || extensionFile == ".gif") {
                    if (userSinged.UserImageFile is not null) {
                        userSinged.UserImageFileName = "User_Image_Icon_" + userSinged.Id + extensionFile;
                        var file = Path.Combine(webEnv.ContentRootPath, "wwwroot/images/userPhoto", userSinged.UserImageFileName);

                        using (var fileStream = new FileStream(file, FileMode.Create)) {
                            await user.UserImageFile.CopyToAsync(fileStream);
                        }
                        identityRepository.Update(userSinged);
                    }
                }
            }

            return RedirectToPage("AccountInfo");
        }
    }
}
