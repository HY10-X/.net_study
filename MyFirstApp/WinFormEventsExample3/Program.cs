using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEventsExample3
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyForm form = new MyForm();
            form.ShowDialog();
        }
    }
    class MyForm : Form
    {
        private TextBox TextBox;
        private Button Button;
        /// <summary>
        /// 
        /// </summary>
        public MyForm()
        {
            this.TextBox = new TextBox();
            this.Button = new Button();
            this.Controls.Add(this.Button);
            this.Controls.Add(this.TextBox);
            this.Button.Click += this.ButtonClicked;
            this.Button.Text= "say hello";
            this.Button.Top = 100;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.TextBox.Text = "Hello,World";
        }
    }
}
