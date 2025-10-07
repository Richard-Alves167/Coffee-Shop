using CafeteriaKwai.Data.Models;

namespace CafeteriaKwai.Data {
    public interface IIdentityRepository {
        public void Add(ApplicationUser user);
        public ApplicationUser GetById(string id);
        public ApplicationUser GetByEmail(string email);
        public List<ApplicationUser> GetAll();
        public void Update(ApplicationUser user);
        public void Delete(string id);
    }
}