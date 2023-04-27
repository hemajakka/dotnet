namespace InheritanceDemo
{
    class operators
    {
        public operators() 
        {
            Console.WriteLine("this is operator class");
        }
        public void show()
        {
            Console.WriteLine("this is show method");
        }
    }
    class Arithmeticoperators :operators
    {
        public Arithmeticoperators()
        {
            Console.WriteLine("this is  arithmeticoperator class");
        }
        public void sum(int x,int y) 
        {
            Console.WriteLine( x + y);
        }
        public void subtract(int x,int y) 
        {
            Console.WriteLine(x - y);
        }
        public void multiply(int x,int y) {
            Console.WriteLine(x * y);
        }
    }
    class logicaloprators:Arithmeticoperators
    {
        public logicaloprators() 
        {
            Console.WriteLine("this logical operator class");
        }
        bool a=true;
        bool b=false;
        bool result;
        public void andoperator()
        {
            result = a && b;
            Console.WriteLine(result);
           ;
        }
        public void oroperator()
        {
            result = a || b;
            Console.WriteLine(result);

        }
    }
      

    internal class Program
    {
        static void Main(string[] args)
        {
            logicaloprators op = new logicaloprators();
            op.show();
            op.sum(1,2);
            op.subtract(5,2);
            op.multiply(5,2);
            op.andoperator();
            op.oroperator();
        }
    }
}