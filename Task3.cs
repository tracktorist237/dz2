using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class Task3
    {

        public enum Weather
        {
            Sunny,
            Cloudy,
            Rainy,
            Snowy
        }

        public void DescribeWeather(Weather weather)
        {
            switch (weather)
            {
                case Weather.Sunny:
                    Console.WriteLine("It's sunny outside!");
                    break;
                case Weather.Cloudy:
                    Console.WriteLine("It's cloudy outside!");
                    break;
                case Weather.Rainy:
                    Console.WriteLine("It's rainy outside!");
                    break;
                case Weather.Snowy:
                    Console.WriteLine("It's snowy outside!");
                    break;
                default:
                    Console.WriteLine("Unknown weather type!");
                    break;
            }

        }
    }
}
