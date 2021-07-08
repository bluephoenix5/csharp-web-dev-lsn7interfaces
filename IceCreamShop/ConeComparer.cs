using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            int xInt = (int)(x.Cost * 100);           
            int yInt = (int)(y.Cost * 100);          
            return xInt - yInt;

            int xIn = xInt;
            double xOut = Convert.ToDouble(xIn);

            int yIn = yInt;
            double yOut = Convert.ToDouble(yIn);
        }

    }
}
