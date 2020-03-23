using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteringuppgift
{
    class Program
    {
        //linjärsökning
        static int Numbsearch(List<int> numbs, int valeu)
        {
            int firstnumb = 0;
            int lastnumb = numbs.Count;
            int index = (lastnumb - firstnumb) / 2;
            while (numbs[index] != valeu)
            {
                if (valeu < numbs[index])
                {
                    if (valeu < numbs[index])
                    {
                        lastnumb = index - 1;
                        index = (lastnumb - firstnumb) / 2;
                    }
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            List<int> numbs = new List<int> { 1, 2, 3, 4, 8 };

            int searchnumb = 2;

            int index = Numbsearch(numbs, searchnumb);
            Console.WriteLine("Värdet " + searchnumb + " ligger på plats " + index);


        }
    }
}
