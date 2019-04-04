using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmsAuto.Interface
{
    interface ISort
    {
        int n { get; set; }

        void Compare();
        void SetValues();

    }
}
