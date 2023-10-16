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
            //异常处理
            Calculator c=new Calculator();
            int r = 0;
            try{
                r=c.Add("99","90");
            }
            //调用函数的程序也可以通过throw抛出异常，谁调用谁捕获
            catch(OverflowException oe){
                System.Console.WriteLine("oe.Message");
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
            bool hasError=false;
            //捕获各种异常，并打印异常信息
            try{
                a= int.Parse(arg1);
                b= int.Parse(arg2);
            }
        catch(ArgumentNullException ane){
            System.Console.WriteLine(ane.Message);
            hasError=true;
        }
        catch(FormatException(fe)){
            System.Console.WriteLine(fe.Message);
            hasError=true;
        }
        catch(OverflowException(oe)){
            //System.Console.WriteLine(oe.Message);
            //可以抛出让主程序捕获异常
            throw oe;
            //throw的使用比较灵活，可以简写为throw不用定义异常对象
            //也可以识别到抛出的异常
            hasError=true;
        }
        finally{//释放系统资源，无论是否发生异常
                //编写程序log,告诉发生异常写在if里
            if(hasError){
                System.Console.WriteLine("Execution has happened");
            }
        }
        }



    }
    }
}
