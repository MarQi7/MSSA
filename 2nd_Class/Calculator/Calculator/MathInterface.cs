using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface MathInterface
    {
        double Add(double num1, double num2);

        double Multiply(double num1, double num2);

        double Divide(double x, double y);

        double Subtract(double x, double y);
      

    }
}
