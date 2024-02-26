using System;
using  System.Timers;
using Timer = System.Timers.Timer;

namespace EventExample

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.事件的拥有者,timer对象
            Timer timer = new Timer();
            //对象拥有方法,属性,事件.事件确保在什么事件情况下通知谁 
            //2.获取或设置引发 Elapsed 事件的间隔（以毫秒为单位）
            timer.Interval = 1000;//ms
            //3.事件的响应者,boy对象,
            Boy boy = new Boy();
            //4.事件的订阅,timer 的Elapsed事件订阅了boy对象的事件处理器,+=后跟事件响应者的事件处理器,Interval达到间隔1000ms时发生。
            timer.Elapsed+=boy.Action;
            //一个事件同时有两个事件处理器的操作
            timer.Elapsed += girl.Action;
            timer.Start();

            Console.ReadLine();
        }
        /// <summary>
        /// 类方法,事件的响应者
        /// </summary>
        class Boy
        {/// <summary>
        /// 5.事件的处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
            internal void Action(object? sender, ElapsedEventArgs e)
            {
                Console.WriteLine("Jump!");
            }
        }
        class girl
        {
            internal static void Action(object? sender, ElapsedEventArgs e)
            {
                Console.WriteLine("Sing!");

            }
        }
    }
}