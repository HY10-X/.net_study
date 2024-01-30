using System.Linq;
namespace ParametersExample
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //想调用calculate方法必须先声明,较为啰嗦,可以使用params关键字
            //int[] IntmyArray = new int[] { 1, 2, 3 };
            //用params关键字声明后不用声明数组
            int[] IntmyArray = {1,2,3};
            int result=CalculatorSum(IntmyArray);
            Console.WriteLine(result);

            string str1 = "tim;tom,amy.lisa";
            string[] result1= str1.Split(';',',','.');
            foreach(string name in result1) {
                Console.WriteLine(name);
            }

            //不具名调用
            PrintInfo("tim", 18);
            //具名调用,清晰且不受参数顺序影响,是参数的使用方法
            PrintInfo(name:"tom",age:22);
            PrintInfoDefault();

            //x就是round方法的第一个参数,当无法修改方法的源码时,可以使用扩展方法进行拓展
            double x = 3.14159;
            double y = x.Round(2);
            Console.WriteLine(y);
            //LinQ
            List<int> list = new List<int>() { 11,12,13,14 };
            //All是一个拓展方法,隶属于Enumerable静态类,等效下面的于AllGreaterThanTen()方法
            bool LinqResult = list.All(x => x > 10);
        }
        /// <summary>
        /// 数组类型参数,只需要在参数前加上params关键字即可
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        static int CalculatorSum(params int[] intArray)
        {

            int sum = 0;
            foreach (int i in intArray)
            {
                sum += i;
            }
            return sum;
        }
        /// <summary>
        /// 具名参数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void PrintInfo(string name,int age)
        {
            Console.WriteLine("Hello {0},you are {1}",name,age);
        }
        /// <summary>
        /// 可选参数,在声明时具有调用值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void PrintInfoDefault(string name="张三",int age=9)
        {
            Console.WriteLine("Hello {0},you are {1}", name, age);
        }

        ///
        static bool AllGreaterThanTen(List<int> IntList)
        {
            foreach (int i in IntList)
            {
                if (i < 10)
                {
                    return false;
                }
            }
            return true;
        }
     
    }
    /// <summary>
    /// 拓展方法
    /// 扩展方法必须在顶级静态类上定义,不能在嵌套类中定义扩展方法。和program类平级,且方法必须是静态,公共的
    /// this必须是形参列表中的第一个
    /// </summary>
    static class DoubleExtension
    {
        public static double Round(this double input, int digits)
        {

            double result = Math.Round(input, digits);
            return result;
        }

    }

}