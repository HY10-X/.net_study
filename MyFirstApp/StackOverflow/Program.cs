using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class BadGuy
    {
        public void BadMethod()//栈溢出
        {
            this.BadMethod();

        }


    }
}
