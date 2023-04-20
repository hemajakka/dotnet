namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length and breadth of rectangle");
            double length = Convert.ToDouble(Console.ReadLine());
            double breadth = Convert.ToDouble(Console.ReadLine());
            double perimeter=2*(length+breadth);
            Console.WriteLine(perimeter);
        }
    }
}