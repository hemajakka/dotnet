using My_Library;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entr choice 1 for sum , 2 for subtraction , 3 for multiplication , 4 for division");
            int choice=Convert.ToInt16(Console.ReadLine());
            Calculator  calculator = new Calculator();
            switch (choice)
            {
                case 1:
                    Console.WriteLine(calculator.sum(a, b));
                    break;  
                case 2:
                    Console.WriteLine(calculator.subtract(a, b));
                    break;
                case 3:
                    Console.WriteLine(calculator.multiply(a, b));
                    break;
                case 4:
                    Console.WriteLine(calculator.divide(a, b));
                    break;
            }Console.ReadKey();
           
        }
    }
}