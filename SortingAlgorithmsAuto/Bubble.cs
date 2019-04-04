using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SortingAlgorithmsAuto.Interface;

namespace SortingAlgorithmsAuto
{
    class Bubble : ISort
    {
        public int n { get; set; }
        public int[] arr { get; set; }
        Stopwatch timePerParse;
        private long ticksThisTime;

        public Bubble(int num)
        {
            n = num;
            arr = new int[n];
        }

        public void SetValues()
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10000);
            }
            Console.WriteLine("The Bubble");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Compare();
        }

        public void Compare()
        {
            DateTime startTime = DateTime.Now;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] >= arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            DateTime endTime = DateTime.Now;
            Console.WriteLine("The Time " + (endTime - startTime));
            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
        }
    }
}
