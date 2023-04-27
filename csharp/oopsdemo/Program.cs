namespace oopsdemo
{
    class calculator
    {
        public void show()
        {
            Console.WriteLine("this is a show method");
        }
        public void SayHello(string name) 
        { 
            Console.WriteLine($"welcome {name}");
        }
        public void mod(int d,int e)
        {
            Console.WriteLine(d%e);
        }
        public void sum(int a ,int b)
        {
            Console.WriteLine($"the sum is {a + b}");
        }
        public int cube(int a ) {
            return a * a * a;
        }
        public void sum(int a,int b=0,int c=0)
        {
            Console.WriteLine(a+ b + c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           calculator cal = new calculator();
            cal.show();
            cal.SayHello("hema");
            cal.sum(10, 20);
            int res= cal.cube(10);
            Console.WriteLine(res);
            cal.sum(10);
            cal.mod(res, 19);
        }
    }
}