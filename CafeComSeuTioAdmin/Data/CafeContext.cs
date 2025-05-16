using System.Security.Cryptography.X509Certificates;
using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeteriaKwai.Data;
    public class CafeContext : DbContext {
    public CafeContext(DbContextOptions options) : base(options) { }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductDetail> ProductDetails { get; set; }
}