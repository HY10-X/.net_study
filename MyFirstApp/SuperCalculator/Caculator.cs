using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperCalculator
{
    public class Caculator
    {
        public static double Add(double a,double b)
        {
            return a + b;    
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static double Chu(double a, double b)
        {
            if (b == 0)
            {
                return a / b;
            }
            else {
                return a / b;
            } 
        }
    }
}
