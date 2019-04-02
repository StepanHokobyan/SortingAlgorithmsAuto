using System;

namespace SortingAlgorithmsAuto
{
    class Start
    {

        public int NOA { get; set; }
        public int OperationSelect { get; set; }

        public void StartProgram()
        {
            
            NOA = int.Parse(Console.ReadLine());
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
