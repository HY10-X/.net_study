using System.Collections.Generic;
using System.Collections;
using System;
using System.Net.Http.Headers;

namespace StatementTestBreak
{
    //testgitnew
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int sum = 0;
            int x = 0;
            int error = 0;
            do
            {
                error = 0;//初始化error标识，避免先前赋值1造成死循环
                Console.WriteLine("input  first number");
                string str1 = Console.ReadLine();
                try
                {

                    x = int.Parse(str1);

                }
                catch
                {
                    if (str1.ToLower() == "end")
                    {
                        break;
                    }
                    error = 1;
                    Console.WriteLine("restart input");
                    continue;

                    //继续循环语句，跳转至do的}最后一个大括号，因此还会执行while的判断，因此需要加入error
                }

                //终止break

                Console.WriteLine("input second number");
                string str2 = Console.ReadLine();
                int y = 0;
                try
                {
                    y = int.Parse(str2);
                }
                catch
                {
                    error = 1;
                    Console.WriteLine("restart second input");
                    continue;

                }
                sum = x + y;
                if (sum == 100)
                {
                    score++;
                }

            }
            while (sum == 100 || error == 1);
            Console.WriteLine("your score is {0}", score);


            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("hello");
                counter++;
            }
            for (int counter2 = 0; counter2 < 10; counter2++)
            {
                Console.WriteLine("helloworld");
            }
            //9*9乘法
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    Console.WriteLine("{0}*{1}={2}\t", a, b, a * b);
                    if (b > a)
                    {
                        break;
                    }

                }

            }
            //foreach,集合遍历循环
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };
            //数组类型Array
            Console.WriteLine(intArray.GetType().FullName);

            //迭代器,指到哪访问哪个元素
            IEnumerator enumerator= intArray.GetEnumerator();
            while (enumerator.MoveNext())
                //MoveNext将游标移向下一个
            {
                Console.WriteLine(enumerator.Current);
            }
            //foreach用于枚举集合中的每一个元素
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
            //迭代器
            List<int> Intlist = new List<int>() { 1, 2, 3, 4, 5, 6 };
            IEnumerator enumerator1 = Intlist.GetEnumerator();
            while (enumerator1.MoveNext())
            {
                Console.WriteLine(enumerator1.Current);
            }
            //foreach最佳应用场合是在遍历集合元素中
            foreach (var current in Intlist)
            {
                Console.WriteLine(current);
            }
            //跳转语句,尽早return原则

        }
        //跳转语句,尽早return原则
        static void Greeting(string Name)
        {
            if (!string.IsNullOrEmpty(Name))
            {
                //如果是空就返回
                return;
            }
            Console.WriteLine("Hello,{0}",Name);
        }
    }
}