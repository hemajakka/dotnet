namespace simpleinterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 23000;
            double rate = 12.75;
            Console.WriteLine("enter period of time");
            int time=Convert.ToInt16(Console.ReadLine());
            double SI;
            SI = Convert.ToDouble((amount * rate * time)/100);
            Console.WriteLine(SI);

        }
    }
}