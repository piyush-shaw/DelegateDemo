using System;
namespace EventDemo
{
    public delegate void DelEventHandler();
    internal class Demo
    {
        public static event DelEventHandler add;
        public static void InvokeAdd()
        {
            Demo.add.Invoke();
        }
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void USA()
        {
            Console.WriteLine("USA");
        }
        public static void England()
        {
            Console.WriteLine("England");
        }
    }

}

