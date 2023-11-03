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
            //静态构造函数
            static Brush()
            {

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

            //只读readonly字段
            //只读字段可以进行初始化但是不能进行赋值
            public readonly int ID;
            //在数据类型被运行环境加载时初始化,只执行一次
            public Student(int id)
            {
                this.ID=id;
            }

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