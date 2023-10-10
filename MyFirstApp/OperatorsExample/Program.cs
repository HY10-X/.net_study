using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;
namespace OperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //访问数组中元素
            int[] myIntArray = new int[10];//创建数组实例
            int[] youIntArray = new int[] { 1, 2, 3, 4, 5 };//{}初始化器
            //偏移量
            Console.WriteLine(youIntArray[0]);
            Console.WriteLine(youIntArray.Length - 1);

            //访问字典中元素
            Dictionary<string, Student> stuDic = new Dictionary<string, Student>();
            for (int i = 0; i <= 100; i++)
            {
                Student stu = new Student();
                stu.Name = "s_" + i.ToString();
                stu.Score = 100;
                stuDic.Add(stu.Name, stu);//使用名字当索引，将对象当值保存在字典中
            }
            Student number6 = stuDic["s_6"];//使用索引,[]元素访问操作符
            Console.WriteLine(number6.Score);

            //typeof查看数据类型内部结构
            Type t = typeof(int);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.FullName);
            //查看属性类方法的名字
            foreach (var mi in t.GetMethods())
            {
                Console.WriteLine(mi.Name);
            }
            //default操作结构体
            //
            int x = default(int);
            Console.WriteLine(x);
            Form myForm = default(Form);
            //default操作枚举类
            level level = default(level);
            Console.WriteLine(level);
            //new操作符,可以调用实例的初始化器{}
            Form myform = new Form() { Text = "hello", FormBorderStyle = FormBorderStyle.SizableToolWindow };
            myform.ShowDialog();
            //new操作符和成员访问操作符可以直接调用对象初始化器并访问方法
            //不用先实例化对象，用在一次性访问对象中
            new Form().ShowDialog();
            //匿名数据类型,声明隐式变量类型
            var person = new { Name = "Mr.Ok", Age = 34 };
            Console.WriteLine(person.GetType().Name);

            new Student().report();
            new CsStudent().report();
            //checked检验是否溢出
            uint xx = uint.MaxValue;
            Console.WriteLine(xx);
            string binStr = Convert.ToString(x, 2);
            Console.WriteLine(binStr);
            try
            {
                //捕获栈溢出的异常
                uint y = checked(xx + 1);
                Console.WriteLine(y);
            }
            catch (OverflowException)
            {

                Console.WriteLine("OVERFLOW"); ;
            }
            //不安全代码测试,需要先在属性中勾选启用不安全代码
            unsafe
            {
                int xxx = sizeof(StudentSizeOf);
                Console.WriteLine(xxx);
            }
            //指针的访问
            unsafe
            {
                
                StudentPoint stu = new StudentPoint();
                stu.ID = 1;
                stu.Score = 99;
                StudentPoint* pStu = &stu;//创建pStu指针指向stu的内存地址
                //&取地址操作符,*取引用符号,等同(*pStu).score
                pStu->Score = 100;//通过指针的间接访问
                Console.WriteLine(stu.Score);
            }
            //一元操作符+-,与数学运算部分相同，不同的部分在于表达值的范围
            //最大值与最小值的绝对值不对称，有一位用来表示负数的负号
            int a = 100;
            int b =+ a;
            int x1 = 12345678;
            //~通过反转每个位产生其操作数的按位求补
            int y1 = ~x1;
            Console.WriteLine(b);
        }
    }
    enum level
    {
        low,
        mid,
        high
    }
    class Student
    {
        public string Name;
        public int Score;
        public void report()
        {
            Console.WriteLine("student");
        }
    }
    //继承
    class CsStudent : Student
    {
        //这里的new是修饰符,修饰新的report方法，子类隐藏父类方法（不常见）
        new public void report()
        {

            Console.WriteLine("csstudent");

        }
    }
    //sizeof使用
    struct StudentSizeOf { int Id; long score;}
    //->
    struct StudentPoint
    {
        public int ID;
        public long Score;
    }
}
