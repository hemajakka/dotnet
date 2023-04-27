namespace overloading_demo
{
    class class1
    {
        public void sum(int x,int y)
        {
            Console.WriteLine(x + y);
        }
        public void sum(int x,int y,int z)
        {
            Console.WriteLine(x + y+z);
        }
        public void sum(float x,int y)
        {
            Console.WriteLine(x + y);
        }
        public void sum(int x, float y)
        {
            Console.WriteLine(x + y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 cl = new class1();
            cl.sum(1,2);
            cl.sum(2,3,6);
            cl.sum(2.5f, 7);
            cl.sum(30, 3.5f);

        }
    }
}