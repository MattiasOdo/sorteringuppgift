using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteringuppgift
{
    class Program
    {
        
        static int Binarysearch(String[] arr, String c)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = c.CompareTo(arr[m]);

                // Check if x is present at mid  
                if (res == 0)
                {
                    return m;
                }


                // If x greater, ignore left half  
                if (res > 0)
                {
                    l = m + 1;
                }

                // If x is smaller, ignore right half  
                else
                {
                    r = m - 1;
                }
                    
            }
                return -1;
        }
        static void Main(string[] args)
        {
            String[] arr = { "Playsation 4","Playstation 3", };
            String c = "ide";
            int result = Binarysearch(arr, c);

            if (result == -1)
            {
                Console.WriteLine("Element not present");
            }

            else
            {
                Console.WriteLine("Element found at "+ "index " + result);
            }
                

        }
    }
}
