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


        }
    }
}
