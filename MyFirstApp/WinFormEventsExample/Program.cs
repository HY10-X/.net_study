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
        /// 事件的拥有者和事件的响应者,是同一个对象
        /// </summary>
        [STAThread]
        static void Main()
        {
            //事件的拥有者form
            Form form = new Form();
            //事件响应者controller
            Controller controller=new Controller(form);
            form.ShowDialog();  
        }
    }
    class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            //事件click
            if(form!=null)
            {
                //将form赋值给controller实例对象的字段
                this.form = form;
                //事件订阅,将form的点击事件与事件处理器关联起来,this指代当前类的实例
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
