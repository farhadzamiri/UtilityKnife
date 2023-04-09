using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityKnife
{
    public class Calculator
    {
        public static double Sum(int a, int b)
        {
            return a + b;
        }

        public static double Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            return (a / b);
        }
    }
}
