using CafeComSeuTioAdmin.Data;

namespace CafeteriaKwai.Data {
    public interface IProductRepository {
        public void Add(Product produto);
        public Product GetById(int id);
        public List<Product> GetAll();
        public List<Product> GetAllLastLimitSelected(int limit);
        public List<Product> GetSearchLimitSelected(string search, int limit);
        public List<Product> GetAllOneCategory(string category);
        public List<Product> GetAllOneCategoryLimitSelected(string category, int limit);
        public Product GetLastOneCategory(string category);
        public List<Product> GetAllFilter();
        public List<Product> GetAllDeleted();
        public void Update(Product product);
        public void Delete(int id);
        public void LogicalDelete(int id);
    }
}
