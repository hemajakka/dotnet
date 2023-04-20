namespace temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter celcius");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit;
            fahrenheit = (celcius * 9) / 5 + 32;
            Console.WriteLine(fahrenheit);
        }
    }
}