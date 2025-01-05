using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class Task1
    {
        int[] array = new int[50];
        string[] fruits = {"яблоко", "банан", "вишня", "ананас", "апельсин", "груша" };

        public void FillArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            Console.WriteLine(string.Join(", ", array));
        }
        public void SumDivisibleBy7()
        {
            int sum = array.Where(x => x % 7 == 0).Sum();
            Console.WriteLine("Sum of numbers divisible by 7: " + sum);
        }
        public void MaxOdd()
        {
            int maxOdd = array.Where(x => x % 2 != 0).Max();
            Console.WriteLine("Max odd number: " + maxOdd);
        }
        public void GroupByEvenOdd()
        {
            var evenOdd = array.GroupBy(x => x % 2 == 0 ? "Even" : "Odd");
            foreach (var group in evenOdd)
            {
                Console.WriteLine(group.Key + ": " + string.Join(", ", group));
            }
        }
        //Найдите все фрукты, начинающиеся с буквы `а`
        public void FindFruits()
        {
            var fruitsWithA = fruits.Where(x => x.StartsWith("а"));
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Fruits starting with 'a': " + string.Join(", ", fruitsWithA));
        }
        //Подсчитайте общее количество букв во всех названиях фруктов
        public void CountLetters()
        {
            int count = fruits.Sum(x => x.Length);
            Console.WriteLine("Total number of letters in all fruit names: " + count);
        }
        //Отсортируйте фрукты в порядке убывания длины названия
        public void SortFruits()
        {
            var sortedFruits = fruits.OrderByDescending(x => x.Length);
            Console.WriteLine("Fruits sorted by name length: " + string.Join(", ", sortedFruits));
        }

    }
}
