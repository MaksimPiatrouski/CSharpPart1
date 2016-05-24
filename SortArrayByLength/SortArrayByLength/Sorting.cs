using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayByLength
{
    class Sorting
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arrayLength = 10;

            Console.WriteLine("Unsorted Array:\n");
            
            String[] array = new String[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = Guid.NewGuid().ToString("n").Substring(0, random.Next(1, 30));
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("\nSorted Array:\n");

            string temp = null;

            for (int j = 0; j < array.Length; j++)
            {
                for (int k = 0; k < array.Length - 1; k++)
                {
                    if (array[k].Length > array[k + 1].Length)
                    {
                        temp = array[k + 1];
                        array[k + 1] = array[k];
                        array[k] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            Console.ReadKey();
        }
    }
}
