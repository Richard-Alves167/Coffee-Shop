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

        Product IProductRepository.GetById(int id) {
            return _context.Products.Find(id);
        }

        void IProductRepository.Update(Product product) {
            //_context.Products.Update(product);
        }
    }
}
