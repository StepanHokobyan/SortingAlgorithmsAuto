using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SortingAlgorithmsAuto.Interface;

namespace SortingAlgorithmsAuto
{
    class Merge : ISort
    {
        public int n { get; set; }
        public int[] arr { get; set; }
        Stopwatch timePerParse;
        private long ticksThisTime;

        public Merge(int num)
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
            Console.WriteLine("The Merge");
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
            int z = 2;
            for (int i = 0; i < n-1; i += 2)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }
            for (int i = 1; i < n - 1; i += 2)
            {
                if (arr[i - 1] > arr[i + 1])
                {
                    int temp = arr[i + 1];
                    arr[i + 1] = arr[i - 1];
                    arr[i - 1] = temp;
                }
                else if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }
            
            while(z > 0){
                for (int i = 0; i < n - 1; i += 1)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                z--;
            }
            Console.WriteLine("Sorted"); ;
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
