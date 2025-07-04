using System.Collections.Generic;
using CafeComSeuTioAdmin.Data;

namespace CafeteriaKwai.Data {
    public class ProductRepositoryEF : IProductRepository {
        CafeContext _context {  get; set; }

        public ProductRepositoryEF (CafeContext cafeContext) {
            _context = cafeContext;
        }

        void IProductRepository.Add(Product produto) {
            _context.Products.Add(produto);
        }
        void IProductRepository.Delete(int id) {
            var deletedItem = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            _context.Products.Remove(deletedItem);
            _context.SaveChanges();
        }
        void IProductRepository.LogicalDelete(int id) {
            var deletedLogicalItem = _context.Products.First(p => p.Id == id);
            deletedLogicalItem.Deleted = true;
            _context.Products.Update(deletedLogicalItem);
            _context.SaveChanges();
        }

        List<Product> IProductRepository.GetAll() {
            return _context.Products.ToList();
        }
        List<Product> IProductRepository.GetAllLastLimitSelected(int limit) {
            return _context.Products.Where(p => p.Deleted == false).OrderByDescending(p => p.Id).Take(limit).ToList();
        }
        List<Product> IProductRepository.GetAllOneCategory(string category) {
            return _context.Products.Where(p => p.Category == category && p.Deleted == false).ToList();
        }
        List<Product> IProductRepository.GetAllOneCategoryLimitSelected(string category,int limit) {
            return _context.Products.Where(p => p.Category == category && p.Deleted == false).Take(limit).ToList();
        }
        Product IProductRepository.GetLastOneCategory(string category) {
            return _context.Products.Where(p => p.Category == category && p.Deleted == false).OrderBy(p => p.Id).Last();
        }
        List<Product> IProductRepository.GetAllFilter() {
            return _context.Products.Where(x => x.Deleted == false).ToList();
        }
        List<Product> IProductRepository.GetAllDeleted() {
            return _context.Products.Where(x => x.Deleted == true).ToList();
        }

        Product IProductRepository.GetById(int id) {
            return _context.Products.First(p => p.Id == id);
        }

        void IProductRepository.Update(Product product) {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
