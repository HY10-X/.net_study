namespace DelegateExample_point
{
    //声明委托类型
    public delegate int Cal(int x,int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            
            //只需要Calculator类的方法名,Action类型委托
            Action action = new Action(calculator.Report);
            //直接调用方法
            calculator.Report();
            //间接调用,Invoke调用
            action.Invoke();
            //等效于间接调用,模仿函数指针的方法
            action();
            /**************************************************************************************************************/
            //定义Func类型委托
            Func<int,int,int>func1=new Func<int, int, int>(calculator.Add);
            Func<int,int,int>func2 = new Func<int,int,int>(calculator.Sub);
            int x = 100;
            int y = 100;
            int z = 0;
            z = func1.Invoke(x, y);
            //使用函数指针式的写法
            z=func1(x, y);
            Console.WriteLine(z);
            z = func2.Invoke(x, y);
            //使用函数指针式的写法
            z = func2(x, y);
            Console.WriteLine(z);
            /**************************************************************************************************************/
            //引用自定义的委托类型
            Cal cal1=new Cal(calculator.Add);
            Cal cal2=new Cal(calculator.Sub);
            Console.WriteLine(cal1(1, 2));
            Console.WriteLine(cal2(1,2));
            /**************************************************************************************************************/
            //准备工厂,包装类实例
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();
            Func<Product> func3 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func4=new Func<Product> (productFactory.MakeToyCar);
            Action<Product> log=new Action<Product>(Logger.Log);
            //间接调用
            Box box1 = wrapFactory.WrapProduct(func3,log);
            Box box2 = wrapFactory.WrapProduct(func4,log);
            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }
    /// <summary>
    /// 记录程序运行的log
    /// </summary>
    class Logger
    {
        /// <summary>
        /// 记录product对象创建的数据
        /// </summary>
        public static void Log(Product product)
        {
            Console.WriteLine("Product{0} created at {1}.Price is {2}",product.Name,DateTime.UtcNow,product.Price);
        }
    }
    /// <summary>
    /// 模板方法
    /// </summary>
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }
    class Box
    {
        public Product Product { get; set; }
    }
    class WrapFactory 
    {/// <summary>
    /// 模板方法,接收一个委托类型Func的参数 Product类型并命名为getProduct,不用重复写打包方法,只接受传进来的委托参数(包装好的函数当作参数传递),能有效提高代码的可重用性
    /// 回调方法,调用一个无返回值的Action类型的委托类型
    /// </summary>
    /// <returns></returns>
        public Box WrapProduct(Func<Product> getProduct,Action<Product> logCallback)
        {
            Box box = new Box();
            //间接调用func3,即MakeToyCar方法
            Product product = getProduct.Invoke();
            box.Product = product;
            //
            if(product.Price >= 50)
            {
                logCallback(product);
            }
            return box;
        }
    }
    /// <summary>
    /// 生产各种产品
    /// </summary>
    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 5;
            return product;
        }
        public Product MakeToyCar()
        {
            Product product= new Product();
            product.Name = "Toy car";
            product.Price = 100;
            return product;
        }
    }
    
    /// <summary>
    /// 委托类型引用的类及方法
    /// </summary>
    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("3 methods");
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }
    }
}