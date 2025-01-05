using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class Task2
    {
        public int[] FilterAndTransform(int[] numbers, int number1, int number2)
        {
            // Filter numbers within range and square them
            return numbers.Where(n => n >= number1 && n <= number2)
                          .Select(n => n * n)
                          .ToArray();
        }
        public void Swap(ref int a, ref int b)
        {
            int temp = a;

            a = b;
            b = temp;

            Console.WriteLine("a = " + a + " b = " + b);
        }

    }
}
