using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEventsExample3
{
    public partial class MyForm1 : Form
    {
        public MyForm1()
        {
            InitializeComponent();
        //    this.MyButton.Click += ButtonClicked;
        }

        //private void ButtonClicked(object sender, EventArgs e)
        //{
        //    this.textBox1.Text = "hello world";
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "helloworld";
        }
    }
}
