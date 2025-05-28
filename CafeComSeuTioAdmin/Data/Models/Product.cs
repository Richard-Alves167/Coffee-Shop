using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeComSeuTioAdmin.Data
{
    public class Product
    {
        public Product() { }
        public Product(string nome, string descricaoPequena, string descricao, decimal preco, string categoria) {
            Name = nome;
            ShortDescription = descricaoPequena;
            Description = descricao;
            Price = preco;
            Category = categoria;
        }
        public List<Product> ListaProdutos() {
            var filename = $"Produtos.txt";
            var caminho = Path.Combine("wwwroot/files", filename);
            List<Product> listaProdutos = new List<Product>();
            try {
                using (StreamReader arquivo = new StreamReader(caminho)) {
                    string linha = arquivo.ReadLine();
                    while (linha != null) {
                        string[] informacoesProduto = linha.Split(",");
                        Product product = new Product(informacoesProduto[0], informacoesProduto[1], informacoesProduto[2], decimal.Parse(informacoesProduto[3]), informacoesProduto[4]);
                        listaProdutos.Add(product);
                        linha = arquivo.ReadLine();
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return listaProdutos;
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MinLength(20,ErrorMessage = "Descrição muito pequena.")]
        public string Description { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string ImageFile { get; set; }
        public string ImageFileName { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public string Category { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }

        public bool Deleted {  get; set; }
    }
}
