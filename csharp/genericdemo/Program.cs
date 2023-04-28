using System.Runtime.InteropServices;

namespace genericdemo
{
    class generic<t>
    {
        t num1;
        public void setvalue(t x)
        { num1 = x; }
        public t getvalue() { return num1; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            generic<int> d= new generic<int>();
            d.setvalue(1);
            Console.WriteLine(d.getvalue());

        }
    }
}