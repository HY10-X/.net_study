using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Form myForm;//声明myform对象
            myForm=new Form();//myform对象引用form实例
            myForm.Text = "myform";
            myForm.ShowDialog();
        }
    }
}
