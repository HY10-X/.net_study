namespace RefParametersExample
{
    internal class Program
    {/// <summary>
    /// 输出参数,引用类型
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Student stu = new Student();
            Student stu = null;
            bool b=StudentFactory.Create("tim",34,out stu);
            if (b==true)
            {
                Console.WriteLine("student {0} age is {1}",stu.Name,stu.Age);
            }
        }
        class Student
        {
            public int Age { get; set; }
            public string Name { get; set; }

        }
        class StudentFactory
        {
            //静态方法根据输入参数实例化对象,并通过输出参数交还创建好的对象
            //静态方法无法访问自己类下的实例状态,但是可以创建和操纵其它类的实例
            public static bool Create(string stuName,int stuAge,out Student result) {
            result = null;
            if(string.IsNullOrEmpty(stuName))
            {       
                    return false;
            }
            if (stuAge>80||stuAge<20)
                {
                    return false;
                }
            result = new Student()
                {
                    Age = stuAge,
                    Name = stuName  
                };
                return true;
            
            }
        }
    }
}