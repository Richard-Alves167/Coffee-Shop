using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text;
using System.Text.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using CafeComSeuTioAdmin.Data.Models;

namespace CafeComSeuTioAdmin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<SurveyItem> listSurvey;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var json = System.IO.File.ReadAllText(Path.Combine("wwwroot/SampleData/survey.json"));
            listSurvey = JsonSerializer.Deserialize<List<SurveyItem>>(json);
        }
    }
}