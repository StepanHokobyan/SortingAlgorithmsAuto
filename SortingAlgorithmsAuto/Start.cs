using System;

namespace SortingAlgorithmsAuto
{
    class Start
    {

        public int NOA { get; set; }
        public int OperationSelect { get; set; }

        public void StartProgram()
        {
            Console.WriteLine("The number of array elements");
            NOA = int.Parse(Console.ReadLine());
            Console.WriteLine("Operations");
            Console.WriteLine("1.Insertation Sorting Algorithm");
            Console.WriteLine("2.Bubble Sorting Algorithm");
            Console.WriteLine("3.Merge Sorting Algorithm");
            Console.WriteLine("4.All Sorting Algorithm");
            OperationSelect = int.Parse(Console.ReadLine());

            Insertion insertion = new Insertion(NOA);
            Bubble bubble = new Bubble(NOA);
            Merge merge = new Merge(NOA);

            switch (OperationSelect)
            {
                case 1:
                    insertion.SetValues();
                    break;
                case 2:
                    bubble.SetValues();
                    break;
                case 3:
                    merge.SetValues();
                    break;
                case 4:
                    insertion.SetValues();
                    bubble.SetValues();
                    merge.SetValues();
                    break;
            }
        }
    }
}
