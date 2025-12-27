using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using Zay_eCommerce.Models;

namespace Zay_eCommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }


        public async Task<IActionResult> ShopSingle(int id)
        {

            var response = await _httpClient.GetAsync($"http://localhost:5104/api/Products/{id}");

            if (!response.IsSuccessStatusCode)
                return NotFound();

            var json = await response.Content.ReadAsStringAsync();

            var product = JsonSerializer.Deserialize<ProductDetailViewModel>(
                json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                );


            product.Images = new List<string>
            {
                product.ProductImage
            };

            return View(product);

        }

        private readonly HttpClient _httpClient;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<IActionResult> Shop()
        {

            var response = await _httpClient.GetAsync("http://localhost:5104/api/Products");


            if (!response.IsSuccessStatusCode)
                return View(new List<ProductListViewModel>());

            var json = await response.Content.ReadAsStringAsync();

            var product = JsonSerializer.Deserialize<List<ProductListViewModel>>(
                json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });


         

            return View(product);

        }

        public IActionResult Contact()
        {
            return View();
        }

   
    }
}
