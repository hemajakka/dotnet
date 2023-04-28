using System.Runtime.InteropServices;

namespace intefacedemo
{
    interface MyInterface
    {
        void add(int x, int y);
        void multiply(int x, int y);
    }
    interface IInterface:MyInterface
    {
        void show();
    }

    class c1 :  IInterface
    {
        public void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void show()
        {
            Console.WriteLine("this is show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            c1 c1 = new c1();
            c1.add(10, 2);
            c1.multiply(11, 2);
            c1.show();

        }
    }
}