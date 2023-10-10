using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorPriority
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=100;
            int y = 200;
            int z = 300;
            x = 3 + 4 + 5;//操作符优先级一样由左向右
            x += y += z;  //带有赋值功能的由右向左运算

            //委托action
            Calculator c=new Calculator();
            Action myAction=new Action(c.PrintHello);
            myAction();

        }
    }
    class Calculator { 
        public double Add(double a,double b){
            return a+b;
        }
        public void PrintHello() {
            Console.WriteLine("hello");
        }
    
    
    }
}
