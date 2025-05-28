using CafeComSeuTioAdmin.Data;

namespace CafeteriaKwai.Data {
    public class ProductRepositoryEF : IProductRepository {
        CafeContext _context {  get; set; }

        public ProductRepositoryEF (CafeContext cafeContext) {
            _context = cafeContext;
        }

        void IProductRepository.Add(Product produto) {
            //_context.Products.Add(produto);
        }
        void IProductRepository.Delete(int id) {
            //_context.Products.Remove(id);
        }

        List<Product> IProductRepository.GetAll() {
            return _context.Products.ToList();
        }

        List<Product> IProductRepository.GetAllFilter() {
            return _context.Products.Where(x => x.Deleted == false).ToList();
        }
        List<Product> IProductRepository.GetAllDeleted() {
            return _context.Products.Where(x => x.Deleted == true).ToList();
        }

        Product IProductRepository.GetById(int id) {
            return _context.Products.Find(id);
        }

        void IProductRepository.Update(Product product) {
            //_context.Products.Update(product);
        }
    }
}
