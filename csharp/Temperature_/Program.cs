namespace Temperature_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double celcius = 0;
            while (celcius <= 90)
            {
                i++;
                double fahrenheit = (celcius * 1.8) + 32;
                Console.WriteLine("srno   celcius    fahrenheit");
                Console.WriteLine($"{i}        {celcius}         {fahrenheit}");
                celcius += 10;
            }

        }
    }
}