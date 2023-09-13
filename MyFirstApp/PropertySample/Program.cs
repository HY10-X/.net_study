using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertySample
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureWorkLT2012Entities proxy=new AdventureWorkLT2012Entities();//创建链接实例
            foreach (product p in proxy.Products){
		        Console.WriteLine(p.name);
	}

        }
    }
}
