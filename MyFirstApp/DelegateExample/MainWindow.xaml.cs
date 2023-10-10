using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DelegateExample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //正常声明方法
            // this.myButton.Click += myButton_Click;
            //使用delegate声明匿名方法（不常用）
            //    this.myButton.Click += delegate(object sender, RoutedEventArgs e)
            //{
            //    this.myTextBox.Text = "Hello,World!";
            //};

            //纳姆塔表达式声明表达方法
            this.myButton.Click += (sender, e) =>
            {
                this.myTextBox.Text = "HelloWorld";
            };
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {

        }
        /*正常声明方法
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            this.myTextBox.Text = "Hello,World!";
        }
         */
    }
}
