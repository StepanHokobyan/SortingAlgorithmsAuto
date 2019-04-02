using System;
using SortingAlgorithmsAuto.Interface;

namespace SortingAlgorithmsAuto
{
    class Insertion : ISort
    {
        public  int n { get; set; }
        public int[] arr { get; set; }

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
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Compare();
        }

        public void Compare()
        {
            for (int i = 1; i < n; i++)
            {
                int val = arr[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
