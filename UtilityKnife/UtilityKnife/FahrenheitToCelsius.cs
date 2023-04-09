using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityKnife
{
    public class FahrenheitToCelsius
    {
        public double FahrenheitToCelsiusConverter(double fahrenheitTemp)
        {
            double _celsius = 0.0;

            var step1 = Calculator.Subtract(fahrenheitTemp, 32);

            var step2 = Calculator.Multiply(step1, 5.0);

            _celsius = Calculator.Divide(step2, 9.0);

            return _celsius;
        }
    }
}
