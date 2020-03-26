using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarysearchnumb
{
    class Program
    {
       

        static int LinarySearch(List<int> numbs, int value)
        {
            for(int i =0; i < numbs.Count; i++)
            {
                if(numbs[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        static int BinarySearch(List<int> numbs, int value)
        {
            int firstnumb = 0;
            int lastnumb = numbs.Count;
            while (firstnumb < lastnumb)
            {
                int index = (firstnumb + lastnumb) / 2;

                if (value == numbs[index])
                {
                    return index;
                }
                else if (value > numbs[index])
                {
                    firstnumb = index + 1;
                }
                else if (value < numbs[index])
                {
                    lastnumb = index;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> numbs = new List<int>();
            for (int i = 0; i < numbs.Count; i++)
            {
                numbs.Add(rand.Next(0, 100));
            }

            int numbfind = 200;
            //Linjärsökning
            var watch = System.Diagnostics.Stopwatch.StartNew(); 
            int index = LinarySearch(numbs, numbfind); 
            watch.Stop(); 
            long elapsedMs = watch.ElapsedMilliseconds; 
            Console.WriteLine("Liner search");
            Console.WriteLine("The value " + numbfind + "is in place" + index);
            Console.WriteLine("It took " + elapsedMs + "ms to find " + numbfind + " in an unsorted list of " + numbs.Count + " numbers");

            //Binärsökning
            watch = System.Diagnostics.Stopwatch.StartNew(); 
            index = BinarySearch(numbs, numbfind); 
            watch.Stop(); 
            elapsedMs = watch.ElapsedMilliseconds; 
            Console.WriteLine("Bynary search");
            Console.WriteLine("The value " + numbfind + "is in place" + index);
            Console.WriteLine("It took " + elapsedMs + "ms to find " + numbfind + " in an unsorted list of " + numbs.Count + " numbers");


        }
    }
}
