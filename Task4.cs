using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class Task4
    {
        public int RecursiveSum(int[] array, int length)
        {
            if (length == 0)
            {
                return 0;
            }
            return array[length-1] + RecursiveSum(array, length - 1);
        }   
    }
}
