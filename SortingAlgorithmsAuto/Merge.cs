using System;
using System.Collections.Generic;
using System.Text;
using SortingAlgorithmsAuto.Interface;

namespace SortingAlgorithmsAuto
{
    class Merge : ISort
    {
        public int n { get; set; }
        public int[] arr { get; set; }

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
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Compare();
        }

        public void Compare()
        {
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
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
