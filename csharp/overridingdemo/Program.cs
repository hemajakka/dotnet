namespace overridingdemo
{
    class c1
    {
        public virtual void show() {
            Console.WriteLine("this is show method of c1");
        }
    }
    class c2:c1
    {
        public override void show() { Console.WriteLine("this is show method of class c2"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            c2 c = new c2();
            c.show();
        }
    }
}