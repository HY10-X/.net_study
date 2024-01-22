namespace ConstantExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WESPEC.WebSiteURL);
        }
        /// <summary>
        /// intro:使用math类中的常量
        /// </summary>
        /// <param name="r"></param>
        /// <returns>s</returns>
        static double GetArea(double r)
        {
            double s = Math.PI * r * r;
            return s;
        }
        /// <summary>
        /// 自定义常量,不用编译,相比变量能够起到节约系统资源的作用,提高程序运行效率,const编译时直接使用常量的值来代替常量名
        /// </summary>
        class WESPEC
        {
            public const string WebSiteURL = "https://www.waspec.org";
        }
    }
}