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
            Stone stone=new Stone();
            stone.Age=50000;
            //使用自创的Monkey类型转换stone
            Monkey wukong1 =new Monkey();
            wukong1 = (Monkey)stone;
            //可以简写为Monkey wukong1=(Monkey)stone;
            Console.WriteLine(wukong1.Age);

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
        public static implicit operator Monkey(Stone stone){
            Monkey m=new Monkey();
            m.Age=stone.Age/500;
            return m;
        }
    }
    class Monkey
    {

        public int Age;

    }
}
