using System;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace magicmirror.Controllers{
    public class HomeController: Controller
    {
        private IHttpClientFactory _httpClientFactory;
        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory=httpClientFactory;
        }

        public IActionResult Index () => View();

        public IActionResult GetWeather() 
        {
            var httpClient = _httpClientFactory.CreateClient();

            var response = httpClient.GetAsync("");
        }
    }
}