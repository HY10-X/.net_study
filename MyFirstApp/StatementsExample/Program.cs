using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatementsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = 5 > 3;
            if (result)
            {
                Console.WriteLine("1111");//嵌入式语句，被嵌套在if中
            }
            var x = 100;
            //x = "asdad"; 字符串类型无法隐式转换为int
            Console.WriteLine(x.GetType().FullName);
            //const常量声明，不可再更改值，且必须初始化即赋值
            const int x2 = 1;
            //表达式语句
            x++;
            x--;
            --x;
            ++x;
            //块语句
            //无论有多少条子语句，编译器都将块语句当作一条看待
            {
                //声明语句
                int x3 = 100;
                //嵌入式语句
                if (x>80)//上文变量块内可以访问
                {
                    Console.WriteLine(x);
                }
                //标签语句
            hello: Console.WriteLine("hello");
           // goto hello;
            int y1 = 200;
                Console.WriteLine(y1);
            }
            //变量的作用域，y1只在块语句之内起作用
            Console.WriteLine(y1);




///////////////////////////////////////////////////////////////////////
///循环语句测试
        int score=0;
        bool canContinue=true;
        /*while循环
        while (canContinue)
        {
            System.Console.WriteLine("input x");
            string str1=Console.ReadLine();
            int x=int.Parse(str1);
            System.Console.WriteLine("input y");
            string str2=Console.ReadLine();
            int y=int.Parse(str2);
            int sum =x+y;
            if (sum==100)
            {
                score++;
                //{}代表后面填入的变量
                System.Console.WriteLine("correct:{0}={1}+{2}",x,y,sum);
            }
            else
            {
                System.Console.WriteLine("error:{0}={1}+{2}",x,y,sum);
                canContinue=false;
            }
        }
        */
        //do循环
        int sum=0;
        do{
            System.Console.WriteLine("input x");
            string str1=Console.ReadLine();
            int x=int.Parse(str1);
            System.Console.WriteLine("input y");
            string str2=Console.ReadLine();
            int y=int.Parse(str2);
            sum =x+y;
            if (sum==100)
            {
                score++;
                //{}代表后面填入的变量
                System.Console.WriteLine("correct:{0}={1}+{2}",x,y,sum);
            }
            else
            {
                System.Console.WriteLine("error:{0}={1}+{2}",x,y,sum);
                canContinue=false;
            }
        }
        while(sum==100);

        System.Console.WriteLine("score is {0}",score);
        System.Console.WriteLine("game over");
        }
    }
}
