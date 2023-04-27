namespace abstractdemo
{
    abstract class c1
    {
        abstract public void add(int x,int y);
        abstract public void subtract(int x,int y);
    }
    class c2 : c1
    {
        public override void add(int x,int y)
        {
            Console.WriteLine(x + y);
        }
        public override void subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            c2 c = new c2();
            c.add(1,2);
            c.subtract(5,2);
        }
    }
}