using System;

namespace ChuanHoangUtilLive
{
    using TestNameSpace;
    class Program
    {
        static void Main()
        {
            TestClass.Hello();
        }
    }
}

namespace TestNameSpace
{
    class TestClass
    {
        public static void Hello() => Console.WriteLine("Hello from Test!");
    }
}