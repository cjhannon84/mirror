using System;
using System.Collections.Generic;

namespace magicmirror.Models
{
    public class WeatherViewModel
    {
        public List<WeatherItem> weather {get;set;}
    }

    public class WeatherItem 
    {
        public int ID {get;set;}
        public string main {get;set;}
        public string description {get;set;}
        public string icon {get;set;}
    }
}