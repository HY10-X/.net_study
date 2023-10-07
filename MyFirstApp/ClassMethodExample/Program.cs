using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator AddObeject = new Calculator();//实例化add为calculator对象，声明add是Calculator类的对象
            int x = AddObeject.Add(1, 2);
            Console.WriteLine(x);
            Calculator GetDayObject = new Calculator();//声明GetDayObject是Calculator类的对象
            string day = GetDayObject.GetToday();//调用对象的方法
            Console.WriteLine(day);
            Calculator PrintSub = new Calculator();
            PrintSub.PrintSum(3, 4);
            PrintSub.PrintXTo1(5);
            PrintSub.printxto1(5);
        }
    }
    class Calculator
    {     //创建计算类
        //创建相加方法(函数),public代表可以在主函数里公开调用
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public string GetToday()
        { //创建计算类下的gettoday方法
            int DayTime = DateTime.Now.Day;
            return DayTime.ToString();
        }
        public void PrintSum(int a, int b)
        {
            var Sum = a + b;
            Console.WriteLine(Sum);
        }
        public void PrintXTo1(int x)
        {
            for (int i = x; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        public void printxto1(int x)
        {   //递归
            if (x == 1)
            {
                Console.WriteLine(x);

            }
            else
            {
                Console.WriteLine(x);
                printxto1(x - 1);

            }


        }
    }
}
