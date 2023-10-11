using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConversationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //不丢失精度的隐式类型转换
            int x = int.MaxValue;
            long y = x;
            Console.WriteLine(y);
            //子类向父类的隐式类型转换
            //使用a访问只能访问到animal方法
            Teacher t = new Teacher();
            Human h = t;
            //h.只能访问到human方法
            Animal a = h;
            //显式类型转换
            System.Console.WriteLine(ushort.MaxValue);
            uint xx = 65535;
            ushort yy = (ushort)xx;
            Console.WriteLine(yy);
            //convert工具类显示转换
            Convert.ToInt32("12345");
            //声明显示类型转换符
            Stone stone = new Stone();
            stone.Age = 50000;
            //使用自创的Monkey类型转换stone
            Monkey wukong1 = new Monkey();
            wukong1 = (Monkey)stone;
            //可以简写为Monkey wukong1=(Monkey)stone;
            Console.WriteLine(wukong1.Age);
            //位与
            int xxxx = 7;
            int yyyy = 28;
            int zzzz = xxxx & yyyy;
            //int zzzz = xxxx | yyyy;

            string strXXXX = Convert.ToString(xxxx, 2).PadLeft(32, '0');
            string strYYYY = Convert.ToString(yyyy, 2).PadLeft(32, '0');
            string strZZZZ = Convert.ToString(zzzz, 2).PadLeft(32, '0');
            Console.WriteLine(strXXXX);
            Console.WriteLine(strYYYY);
            Console.WriteLine(strZZZZ);
            //条件与、条件或
            int xxx = 5;
            int yyy = 4;
            int aaa = 1000;
            int bbb = 2000;
            if (xxx > yyy || aaa < bbb)
            {
                Console.WriteLine("hello");
            }
            //可空数据类型
            //等同Nullable<int> xxxxx = null;
            int? xxxxx = null;//可空整数变量，并赋值为空
            int y5 = xxxxx ?? 1;//加入xxxxx为空，则赋值y5为1
            Console.WriteLine(y5);
            //ifelse的简写,?
            int x6 = 80;
            string str = (x6 >= 60) ? "pass" : "faild";
            Console.WriteLine(str);
            //lambda表达式
            int x7 = 5;
            x7 += 1;//
            int x8 = 7;
            x8 <<= 2;//左移等于，相当于*2
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eatinng");
        }
    }
    class Human : Animal
    {
        //继承animal类
        public void Think()
        {
            Console.WriteLine("whoiam");
        }
    }
    //human派生出teache类
    class Teacher : Human
    {

        public void Teach()
        {
            Console.WriteLine("teaching");
        }
    }
    class Stone
    {
        public int Age;
        //声明显示类型转换操作符，显示类型转换符可以理解为转换类的构造器
        public static implicit operator Monkey(Stone stone)
        {
            Monkey m = new Monkey();
            m.Age = stone.Age / 500;
            return m;
        }
    }
    class Monkey
    {

        public int Age;

    }
}
