using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.IntroductionCSharp.Operators.Arithmetic
{
    public class Calculator
    {
        public int Sum(int n1, int n2)
        {
            

            return n1 + n2;
        }

        public int Mult(int num1, int num2)
        {
            return num1*num2;
        }

        public double Div(double div1, double div2 )
        {
            return div1/div2;//si se usa dato entero se puedo dar que sea return (double)div1 / (double)div2; para que funcione
        }

        public int Subtract(int n1, int n2)
        {
            return  n1 -n2;
        }

        public double Pi()
        {
            return 3.14189;
        }

        public double Module(double n1, double n2)
        {
            return n1 % n2;
        }

    }
}