using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEventsExample2
{
    internal static class Program
    {
        /// <summary>
        /// 自己的事件触发自己(响应者),处理自己。
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyForm form = new MyForm();
            //事件订阅
            form.Click += form.FormClicked;
            form.ShowDialog();
        }
    }
    /// <summary>
    /// 事件处理器
    /// 自己声明form类,派生(继承),在原有的类的基础上,衍生出新的功能
    //myform继承form类,MyForm : Form
    /// </summary>
    class MyForm : Form
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
