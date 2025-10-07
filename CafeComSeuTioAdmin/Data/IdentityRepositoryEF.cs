using CafeteriaKwai.Data.Models;

namespace CafeteriaKwai.Data {
    public class IdentityRepositoryEF : IIdentityRepository {
        ApplicationDbContext identidadeContext {  get; set; }
        public IdentityRepositoryEF(ApplicationDbContext context) {
            identidadeContext = context;
        }
        public void Add(ApplicationUser user) {
            identidadeContext.Users.Add(user);
            identidadeContext.SaveChanges();
        }
        public List<ApplicationUser> GetAll() {
            return identidadeContext.Users.ToList();
        }
        public ApplicationUser GetById(string id) {
            return identidadeContext.Users.FirstOrDefault(u => u.Id == id);
        }
        public ApplicationUser GetByEmail(string email) {
            return identidadeContext.Users.Where(i => i.Email == email).FirstOrDefault();
        }
        public void Update(ApplicationUser user) {
            identidadeContext.Users.Update(user);
            identidadeContext.SaveChanges();
        }
        public void Delete(string id) {
            var DeletedUser = identidadeContext.Users.Where(i => i.Id == id).FirstOrDefault();
            identidadeContext.Users.Remove(DeletedUser);
            identidadeContext.SaveChanges();
        }
    }
}
