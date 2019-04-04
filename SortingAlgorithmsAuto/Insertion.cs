using System;
using System.Diagnostics;
using SortingAlgorithmsAuto.Interface;

namespace SortingAlgorithmsAuto
{
    class Insertion : ISort
    {
        public  int n { get; set; }
        public int[] arr { get; set; }
        Stopwatch timePerParse;
        private long ticksThisTime;

        public Insertion(int num)
        {
            n = num;
            arr = new int[n];
        }
        
        public void SetValues()
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0 , 10000);
            }
            Console.WriteLine("The Insertion");
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
            for (int i = 1; i < n; i++)
            {
                int val = arr[i];
                int end = 0;
                for (int j = i - 1; j >= 0 && end != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else end = 1;
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
