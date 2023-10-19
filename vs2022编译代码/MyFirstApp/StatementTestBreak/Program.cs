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


            int counter=0;
            while (counter<10)
            {
                Console.WriteLine("hello");
                counter++;  
            }
            for (int counter2 = 0; counter2 < 10; counter2++)
            {
                Console.WriteLine("helloworld");
            }
        }
    }
}