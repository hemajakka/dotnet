namespace constructor_demo
{
    class Demo
    {
         static int n = 0;
        public Demo() {
            Console.WriteLine("iam constucor");
        }
        public void inc() 
        {
            n++;
            Console.WriteLine(n);
        }
        public static void show()
        {
            Console.WriteLine("this is show method");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Demo d1 = new Demo();
            Demo d2 = new Demo();   
            d1.inc();
            d2.inc();
            Demo.show();
        }
    }
}