using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiValueCalculationLib
{
    public static class BmiValueCalculationType
    {
        public static int bmivalue;

        public static int calculator(int height, int weight)
        {
            bmivalue = weight / height;
            return bmivalue;
        }




    }
}
