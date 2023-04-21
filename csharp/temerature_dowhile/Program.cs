namespace temerature_dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            char choice;
            
            do 
            {
                Console.WriteLine("enter celcius temperature");
                double celcius = Convert.ToDouble(Console.ReadLine());
                fahrenheit = (celcius * 9) / 5 + 32;
                Console.WriteLine($"temperature of c is {celcius} and f is {fahrenheit}");
                Console.WriteLine("do you want to continue y/n");
                choice=Convert.ToChar(Console.ReadLine());
            }while( choice == 'y' );
        }
    }
}