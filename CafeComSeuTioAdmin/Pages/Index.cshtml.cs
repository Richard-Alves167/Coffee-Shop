using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text;
using System.Text.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using CafeComSeuTioAdmin.Data.Models;
using CafeteriaKwai.Data;
using CafeComSeuTioAdmin.Data;
using Microsoft.AspNetCore.Authorization;

namespace CafeComSeuTioAdmin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<SurveyItem> listSurvey;

        public CafeContext CafeContext { get; set; }
        public IProductRepository ProductRepository { get; set; }

        [BindProperty]
        public List<Product> listaProdutosUltimosLancamentos { get; set; } = new List<Product>();
        public Product ProdutoNovidade1 { get; set; }
        public Product ProdutoNovidade2 { get; set; }
        public Product ProdutoNovidade3 { get; set; }


        public IndexModel(ILogger<IndexModel> logger, IProductRepository productRepository)
        {
            _logger = logger;
            ProductRepository = productRepository;
        }

        public void OnGet()
        {
            var json = System.IO.File.ReadAllText(Path.Combine("wwwroot/SampleData/survey.json"));
            listSurvey = JsonSerializer.Deserialize<List<SurveyItem>>(json);
            listaProdutosUltimosLancamentos = ProductRepository.GetAllLastLimitSelected(3);
        }
    }
}