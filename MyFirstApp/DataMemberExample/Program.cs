using System.Runtime.CompilerServices;

namespace DataMemberExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Age = 40;
            student1.Score = 90;
            Student student2 = new Student();
            student2.Age = 24;
            student2.Score = 60;
            Student.ReportAmount();
            List<Student> StuList = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Age = i;
                StuList.Add(stu);
            }
            Student.ReportAmount();
            int totalAge = 0;
            int totalScore = 0;
            foreach (var student in StuList)
            {
                totalAge += student.Age;
                totalScore += student.Score;
            }
            Student.AverageAge = totalAge / Student.Amount;
            Student.AverageScore = totalScore / Student.Amount;
            Student.ReportAverageAge();
            Student.ReportAverageScore();


            Student student3 = new Student(1);

            Console.WriteLine(Brush.DefaultColor.Red);
            Console.WriteLine(Brush.DefaultColor.Blue);
            Console.WriteLine(Brush.DefaultColor.Green);
            //Brush.DefaultColor = new Color();静态只读字段无法更改

            //private字段
            Student stu1 = new Student();
            stu1.SetHeight(100);
            Student stu2 = new Student();
            stu2.SetHeight(100);
            Student stu3 = new Student();
            stu3.SetHeight(100);
            int avgHeight = (stu1.GetHeight()+stu2.GetHeight()+stu3.GetHeight());
            Console.WriteLine(avgHeight);

        }
        struct Color
        {
            public int Red;
            public int Green;
            public int Blue;
        }
        class Brush
        {
            public static readonly Color DefaultColor = new Color()
            {
                Red = 0,
                Green = 0,
                Blue = 0
            };
            //静态实例构造函数
            static Brush()
            {
                Brush.DefaultColor=new Color() { Red=0,Green=0, Blue=0 };
            }
        }
        //动态计算值的属性
        public class people
        {
            private int age;
            //封装字段
            public int Age {
                get => age; 
                set => age = value; 
            }

            private bool canWork;
            public bool CanWork { 
                get => canWork; 
                set => canWork = value; 
            }

        }
        public class Student
        {
            //实例字段
            //初始化时机是在实例创建阶段
            public int Age=0;//对象的初始化器,任何对象创建age都会是0
            public int Score;
            //用静态字段表示状态方法
            //静态字段初始化时机是在运行环境加载阶段
            //public static int Amount;

            //只读readonly字段
            //只读字段可以进行初始化但是不能进行赋值
            public readonly int ID;
            //在数据类型被运行环境加载时初始化,只执行一次


            //private属性只能在public class student中使用,身高,使用关键字保护字段不受非法值(溢出之类)污染
            //不符合设定值抛出异常,使用GetHeight来获取height,使用SetHeight来初始化height
            private int Height;
            public int GetHeight()
            {
                return this.Height;
            }
            public void SetHeight(int value)
            {
                if (value >= 100 && value <= 200)
                {
                    this.Height = value;
                }
                else
                {
                    throw new Exception("Age value is error");
                }
            }

            public Student(int id)
            {
                this.ID=id;
            }

            //getter与setter 


            public static int AverageAge;
            public static int AverageScore;
            public static int Amount;
            public Student()
            {
                Student.Amount++;
            }
            public static void ReportAmount()
            {
                Console.WriteLine(Student.Amount);
            }
            public static void ReportAverageAge() {
                Console.WriteLine(Student.AverageAge);
            }
            public static void ReportAverageScore() {
                Console.WriteLine(Student.AverageScore);
            }
        }
    }
}