using static System.Formats.Asn1.AsnWriter;

namespace IndexerExample
    ///Intro:
    ///`this`方法在C#中被称为索引器（Indexer）。它允许一个对象像数组一样通过索引进行访问，提供了一种类似数组的方便访问方式。
 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu["Math"] = 100;
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore);
        }
        //根据索引器检索学生成绩
        class Student {
            //字典类型字段,科目名称,科目分数
            private Dictionary<string, int> scoreDictionary=new Dictionary<string, int>();
            ///在这段代码中，`this`方法对字符串参数`subject`进行了重载，
            ///使得可以通过[subject] 这样的形式来获取或设置与某个`subject`相对应的成绩（比如`scores["Math"] = 95;`或`int mathScore = scores ["Math"];`），
            ///增强了类的易用性。如果`subject`不存在，该函数会返回null。
            public int? this[string subject]
            {
                get {
                    //先去寻找是否有这个subject科目表的key
                    if (this.scoreDictionary.ContainsKey(subject))
                    {
                        return this.scoreDictionary[subject];
                    }
                    else
                    {
                        return null;
                    }
                }
                set { 
                    //检验value受否有值
                    if(value.HasValue==false)
                    {
                        throw new Exception("分数不能为空");
                    }
                    if (this.scoreDictionary.ContainsKey(subject)) {
                        //Dictionary的string类型不能传输空值,而int?可空,所以有可能给字典赋空值,这时赋值不能直接赋value,而要使用Value.value
                        this.scoreDictionary[subject] = value.Value;
                     }
                    else
                    {
                    //字典中没有这个科目表的key,新增
                        this.scoreDictionary.Add(subject, value.Value);   


                    }
                }
            }
        }
    }
}