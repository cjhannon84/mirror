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

        public string iconclass 
        {
            get
            {
                switch (icon)
                {
                    case "02d":
                        return "far fa-sun";
                    case "02n":
                        return "far fa-moon";
                    case "09d":
                        return "far fa-clouds-sun";
                    case "09n":
                        return "far fa-clouds-moon";
                    case "10n":
                        return "far fa-raindrops";
                    case "10d":
                        return "far fa-raindrops";
                    case "11d":
                        return "far fa-thunderstorm-moon";
                    case "11n":
                        return "far fa-thunderstorm-moon";
                    case "13d":
                        return "far fa-snowflake";
                    case "13n":
                        return "far fa-snowflake";
                    default:
                        return "far fa-cloud";
                }
            }
        }
    }
}