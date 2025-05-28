using CafeComSeuTioAdmin.Data;

namespace CafeteriaKwai.Data {
    public interface IProductRepository {
        public void Add(Product produto);
        public Product GetById(int id);
        public List<Product> GetAll();
        public List<Product> GetAllFilter();
        public List<Product> GetAllDeleted();
        public void Update(Product product);
        public void Delete(int id);
    }
}
