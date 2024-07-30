using Dapper;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HotelManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string _connectionString;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> TestDapper()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var query = "SELECT 1";
                    var result = await connection.ExecuteScalarAsync<int>(query);
                    return Content(result == 1 ? "Dapper connection successful" : "Dapper connection failed");
                }
                catch (Exception ex)
                {
                    return Content($"Error: {ex.Message}");
                }
            }
        }
    }
}
