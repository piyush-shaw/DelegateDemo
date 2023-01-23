using System;
namespace DelegateDemo
{
	internal class Demo
	{
        public delegate int operation(int x, int y);
        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}

