namespace OutParametersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input A Number:");
            string arg1=Console.ReadLine();
            double x = 0;
            bool  b1= double.TryParse(arg1, out x);//通过out参数拿到输出值
            if (b1 ==false)
            {
                Console.WriteLine("error input");
                Console.WriteLine("{0},{1}",b1,x);
                return;
            }
            Console.WriteLine("Please Input Second Number:");
            string arg2 = Console.ReadLine();
            double y = 0;
            bool b2 = double.TryParse(arg2, out y);//通过out参数拿到输出值
            if (b2 == false)
            {
                Console.WriteLine("error input");
                return;
            }
            double z = x + y;
            Console.WriteLine("{0}+{1}={2}",x,y,z);

            //自定义函数的输出参数
            //能把函数体中的参数输出到主函数中作为变量赋值
            double s = 0;
            //接收tryparse中的参数result并赋值给s
            bool b=DoubleParser.TryParse("789", out s);
            if (b == true) {
                Console.WriteLine("解析成功,已将字符类型转为double类型");
                Console.WriteLine(s+1);
            }
            else
            {
                Console.WriteLine("解析失败");
                //此时即使入参抛出异常out的出参也会被覆盖,赋出参为0
            }
        }
        /// <summary>
        /// 自定义函数的输出参数
        /// </summary>
        class DoubleParser
        {
            public static bool TryParse(string input,out double result)
            {
                try
                {
                    result = double.Parse(input);
                    return true;
                }
                catch
                {
                    result= 0;
                    return false;
                }
            }
           
        }
    }
}