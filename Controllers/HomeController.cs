using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using magicmirror.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace magicmirror.Controllers{
    public class HomeController: Controller
    {
        private IHttpClientFactory _httpClientFactory;

        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory=httpClientFactory;
        }

        public IActionResult Index () => View();

        public async Task<WeatherViewModel> GetWeather() 
        {
            var httpClient = _httpClientFactory.CreateClient();

            var response = await httpClient.GetAsync("http://api.openweathermap.org/data/2.5/weather?q=Crewe,GB&APPID=85440800d8e25bb10f114bbd791d5558");

            var str=await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<WeatherViewModel>(str);
        }
    }
}