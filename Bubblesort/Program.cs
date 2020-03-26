﻿using System;
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
            int j = 0;
            while (listsorted == false)
            {

                listsorted = true;
                for (int i = 0; i < sortlist.Count - 1 - j; i++)
                {
                    if (sortlist[i] > sortlist[i + 1])
                    {
                        int temp = sortlist[i];
                        sortlist[i] = sortlist[i + 1];
                        sortlist[i + 1] = temp;
                        listsorted = false;
                    }
                }
                j++;
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random(0);

            List<int> numbs = new List<int> { 3, 1, 8, 2, 5 };

            for (int i = 0; i < 100000; i++)
            {
                numbs.Add(rand.Next(0,50));
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Bubblesort(numbs);
            var elapsedms = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedms);

            //for (int i = 0; i < numbs.Count; i++)
            //{
            //    Console.WriteLine(numbs[i]);
            //}

        }
    }
}
