using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace ExpressionExamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Int64);
            Console.WriteLine(myType.FullName);
            //
            List<int> intList = new List<int>() { 1, 2, 3 };
            List<double> doubletestarray = new List<double> { 2.0 };
            double[] doubleArray = new double[] { 1.0, 2.0, 3.0 };
            var x = doubleArray[1];
            Console.WriteLine(x.GetType());
            //算术运算符的表达式的数据类型当发生数值提升时与表达式中精度最高的数数据类型一致
            var x1 = 4 / 3;
            Console.WriteLine(x1.GetType());
            //
            Form myForm = new Form();
            myForm.Text = "hello";
            myForm.Load += new EventHandler(myForm_Load);
                //`+=`用于事件订阅
                //将事件处理函数`myForm_Load`添加到`myForm.Load`事件的调用列表中。
            myForm.ShowDialog();
            //程序流测试
            string input = Console.ReadLine();
            try
            {
                double score = double.Parse(input);
                if(score>=60){
                    Console.WriteLine("pass");
                }
                else
                {
                    Console.WriteLine("faild");
                }
            }
            catch
            {
                Console.WriteLine("not number");
            }

          



        }
        //sender:发送者
        static void myForm_Load(object sender, EventArgs e)
        {
            Form form = sender as Form;
            if (form == null)
            {
                return;
            }
            form.Text = "newwwwwwww";
      }
    class Calculator{
        public int Add(string arg1,string arg2){
            int a=0;
            int b=0;
            try{
                a=
            }


        }



    }
    }
}
