using System;
using Microsoft.AspNetCore.Mvc;

namespace magicmirror.Controllers{
    public class HomeController: Controller
    {
        public IActionResult Index () => View();
    }
}