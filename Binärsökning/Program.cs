using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binärsökning
{
    class Program
    {
        static int Numbsearch(List<int> numbers, int valeu)
        {
            int Firstnumb = 0;
            int Lastnumb = numbers.Count;
            int index = (Lastnumb - Firstnumb) / 2;
            while (numbers[index] != valeu)
            {
                if (valeu < numbers[index])
                {
                    if (valeu < numbers[index])
                    {
                        Lastnumb = index - 1;
                        index = (Lastnumb - Lastnumb) / 2;
                    }
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 8 };

            int searchvaleu = 2;

            int index = Numbsearch(numbers, searchvaleu);
            Console.WriteLine("Siffran " + searchvaleu + " ligger på plats " + index);

        }
    }
}
