using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    static class Program    //类名
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()  //主函数
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
