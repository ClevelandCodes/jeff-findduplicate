using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array definition
            int[] arr = { 1, 2, 3, 6, 6, 7, 8 };
            Boolean foundDupe = false;

            // For every element in arr
            for (int i = 0; i < arr.Length; i++)
            {
                // Check against every element in arr
                for (int j = 0; j < arr.Length; j++)
                {
                    // If the value you're checking for (arr[i]) is equal to the value you're checking against (arr[j])
                    // and the indexes are not the same (i != j)
                    if (arr[i] == arr[j] && i != j)
                    {
                        Console.WriteLine("{0} is the duplicate value!", arr[i]);
                        foundDupe = true; // We assume we only need to find 1 duplicate
                        break; // End the inner loop
                    }

                    // If duplicate has been found, we can end the outer loop as well
                    if (foundDupe)
                    {
                        break;
                    }
                }
            }
        }
    }
}
