using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LINQ_Counting_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 5, 2, 32, 4, 8 };

            var count = numbers.Count();

            Console.WriteLine(count);
        }
    }
}
