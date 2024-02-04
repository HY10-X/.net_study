using System.Threading;
namespace MulticastDelegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { Id = 1, PenColor = ConsoleColor.Red };
            Student stu2 = new Student() { Id = 2, PenColor = ConsoleColor.Yellow };
            Student stu3 = new Student() { Id = 3, PenColor = ConsoleColor.Blue };
            Action act1 = new Action(stu1.DoHomeWork);
            Action act2=new Action(stu2.DoHomeWork);
            Action act3=new Action(stu3.DoHomeWork);
            //单播委托
            act1.Invoke();
            act2.Invoke();
            act3.Invoke();
            //多播委托,将act2,act3封装进act1中
            act1 += act2;
            act1 += act3;
            act1.Invoke();
            //同步调用,依次进行执行
            stu1.DoHomeWork();
            stu2.DoHomeWork();
            stu3.DoHomeWork();
            //间接同步调用
            act1.Invoke();
            act2.Invoke();
            act3.Invoke();
            //多播委托的间接同步调用
            act1 += act2;
            act1 += act3;
            act1.Invoke();
            //异步调用,隐式异步调用,分支线程有begininvoke自动生成
            //不需要在异步调用后执行任何方法,入参为null
            act1.BeginInvoke(null,null);
            act2.BeginInvoke(null, null);
            act3.BeginInvoke(null, null);
            //显式异步调用
            //使用thread
            Thread thread1=new Thread(new ThreadStart(stu1.DoHomeWork));
            Thread thread2=new Thread(new ThreadStart(stu2.DoHomeWork));
            Thread thread3=new Thread(new ThreadStart(stu3.DoHomeWork));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            //使用task进行显式异步调用
            Task task1 = new Task(stu1.DoHomeWork);
            Task task2= new Task(stu2.DoHomeWork);
            Task task3= new Task(stu3.DoHomeWork);
            task1.Start();
            task2.Start();
            task3.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread is {0}",i);
                Thread.Sleep(1000);
            }
        }
        class Student
        {
            public int Id { get; set; }
            public ConsoleColor PenColor { get; set; }
            public void DoHomeWork()
            {
                for(int i = 0;i<5;i++)
                {
                    Console.ForegroundColor = this.PenColor;
                    Console.WriteLine("Student{0} doing homework {1} hour(s)",this.Id,i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}