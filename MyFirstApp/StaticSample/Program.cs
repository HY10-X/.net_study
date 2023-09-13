using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");//静态方法
            Form form = new Form();
            form.Text = "hello";//访问实例属性
            form.ShowDialog();//访问实例的方法
        }
    }
}
