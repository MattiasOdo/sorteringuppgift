using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    class Program
    {
        static void Bubblesort(List<int> sortlist)
        {
            bool listsorted = false;

            while (listsorted == false)
            {
                listsorted = true;
                for (int i = 0; i < sortlist.Count - 1; i++)
                {
                    if (sortlist[i] > sortlist[i + 1])
                    {
                        int temp = sortlist[i];
                        sortlist[i] = sortlist[i + 1];
                        sortlist[i + 1] = temp;
                        listsorted = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> numbs = new List<int> { 3, 1, 8, 2, 5 };

            Bubblesort(numbs);
            for (int i = 0; i < numbs.Count; i++)
            {
                Console.WriteLine(numbs[i]);
            }

        }
    }
}
