using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    class Program
    {
        static void Bubblesort(List<ConsoleBubble> sortlist)
        {
            bool listsorted = false;
            while (listsorted == false)
            {

                listsorted = true;
                for (int i = 0; i < sortlist.Count - 1 ; i++)
                {
                    if (sortlist[i] > sortlist[i + 1])
                    {
                        ConsoleBubble temp = sortlist[i];
                        sortlist[i] = sortlist[i + 1];
                        sortlist[i + 1] = temp;
                        listsorted = false;
                    }
                }
            }
        }
        static void PrintList (List<ConsoleBubble> printlist)
        {
            foreach(ConsoleBubble c in printlist)
            {
                Console.WriteLine(c.Name + " came out in " + c.Age + " and weighed " + c.Weight + " kilograms");
            }
        }
        static void Main(string[] args)
        {
            ConsoleBubble consoleA = new ConsoleBubble("Playstation 4", 3, 2013);
            ConsoleBubble consoleB = new ConsoleBubble("Playstation 3", 5, 2006);
            ConsoleBubble consoleC = new ConsoleBubble("Playstation 2", 1, 2000);
            ConsoleBubble consoleD = new ConsoleBubble("Playstation 1", 1, 1994);
            ConsoleBubble consoleE = new ConsoleBubble("Xbox One", 3, 2013);
            ConsoleBubble consoleF = new ConsoleBubble("Xbox 360 ", 3, 2005);
            ConsoleBubble consoleG = new ConsoleBubble("Xbox", 4 , 2002);
            ConsoleBubble ConsoleH = new ConsoleBubble("Nintendo 64", 1, 1996);

            List<ConsoleBubble> Consolelist = new List<ConsoleBubble>();
            Consolelist.Add(consoleA);
            Consolelist.Add(consoleB);
            Consolelist.Add(consoleC);
            Consolelist.Add(consoleD);
            Consolelist.Add(consoleE);
            Consolelist.Add(consoleF);
            Consolelist.Add(consoleG);
            Consolelist.Add(ConsoleH);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Bubblesort(Consolelist);
            var elapsedms = watch.ElapsedMilliseconds;
            Console.WriteLine("It took "+elapsedms+"ms to sort this list");
            Console.WriteLine("");            
            Console.WriteLine("This is the sorted list, the list is sorted with the newest consle to the oldest.");
            Console.WriteLine("");
            PrintList(Consolelist);
            Console.WriteLine("");


        }
    }
}
