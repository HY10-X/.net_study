using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEventsExample
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form = new Form();
            
        }
    }
    class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            //事件
            if(form!=null)
            {
                this.form = form;
                //事件订阅,将事件与事件处理器关联起来
                this.form.Click += FormClicked;
            }
        }
        //事件处理器
        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
