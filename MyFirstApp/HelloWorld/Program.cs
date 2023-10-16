using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SuperCalculator;//引用库
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("helloworld");
            System.Console.WriteLine("systemhelloworld");
            double result = Caculator.Mul(3, 4);
            Console.WriteLine(result);
            //tes
        }
    }
}
