using System;
using System.Collections.Generic;

namespace Version_1_C
{
    class clsNameComparer : IComparer<clsWork>
    {
        public int Compare(clsWork x, clsWork y)
        {
            String lcNameX = x.Name;
            String lcNameY = y.Name;

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
