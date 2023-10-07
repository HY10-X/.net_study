using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(1,"mr.ok");
        }
    }
    class Student
    {
        ///初始化构造器
        public Student(int initID, string initName)
        {
            this.ID = initID;
            this.Name = initName;
        }
        public int ID;
        public string Name;

    }
}
