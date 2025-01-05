using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class ArraysAndLinq
    {
        public static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            Console.WriteLine("----Task 1----");
            Console.WriteLine("");
            task1.FillArray();
            task1.SumDivisibleBy7();
            task1.MaxOdd();
            task1.GroupByEvenOdd();
            task1.FindFruits();
            task1.CountLetters();
            task1.SortFruits();
            Console.WriteLine("--------------");

            Task2 task2 = new Task2();
            Console.WriteLine("----Task 2----");
            Console.WriteLine("");
            int[] numbers = { 1, 5, 10, 15, 20 };
            int[] result = task2.FilterAndTransform(numbers, 5, 15);
            Console.WriteLine(string.Join(", ", result));

            int a = 10, b = 20;
            Console.WriteLine("a = " + a + " b = " + b);
            task2.Swap(ref a, ref b);
            Console.WriteLine("--------------");

            Task3 task3 = new Task3();
            Console.WriteLine("----Task 3----");
            Console.WriteLine("");
            task3.DescribeWeather(Task3.Weather.Sunny);
            task3.DescribeWeather(Task3.Weather.Rainy);
            task3.DescribeWeather(Task3.Weather.Snowy);
            task3.DescribeWeather(Task3.Weather.Cloudy);
            Console.WriteLine("--------------");
        }
    }
}
