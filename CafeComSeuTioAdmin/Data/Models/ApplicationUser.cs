using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CafeteriaKwai.Data.Models {
    public class ApplicationUser : IdentityUser {
        public string UserImageFileName { get; set; }
        [NotMapped]
        public IFormFile UserImageFile { get; set; }
    }
}
