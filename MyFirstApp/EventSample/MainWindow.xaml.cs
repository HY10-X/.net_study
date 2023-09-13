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
using System.Windows.Threading;//引用多线程
namespace EventSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();//实例化时钟
            timer.Interval = TimeSpan.FromSeconds(1); //间隔多长时间触发一次时间
            timer.Tick += timer_Tick;
            timer.Start();//启动计时器
        }

        void timer_Tick(object sender, EventArgs e) //事件处理器，对tick触发的事件进行执行
        {
            this.TimeTextBox.Text = DateTime.Now.ToString();//调用前端的文本框显示当前时间并转为string类型
        }
    }
}
