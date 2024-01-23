namespace RefSomsideEffectExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student outStudent = new Student() { Name="AAA"};
            Console.WriteLine("HashCode={0},name={1}",outStudent.GetHashCode(),outStudent.Name);
            Console.WriteLine("_____________________________________________");
            outStudent.SideEffect(ref outStudent);
            Console.WriteLine("HashCode={0},name={1}", outStudent.GetHashCode(), outStudent.Name);

        }
        /// <summary>
        /// intro:应用类型，不创建新对象，只改变变量值，三次指向同一个地址
        /// </summary>
        class Student
        {
            public string Name { get; set; }
            public void SideEffect(ref Student inStudent)
            {
                inStudent.Name = "BBB";
                Console.WriteLine("HashCode={0},name={1}", inStudent.GetHashCode(), inStudent.Name);

            }
        }
    }
}