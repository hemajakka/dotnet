namespace Largest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st number");
            int num1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter 3rd number");
            int num3 = Convert.ToInt16(Console.ReadLine());
            if((num1>num2) && (num1>num3)) {
                Console.WriteLine("num1 is greater");
            
            }
            else if(num2>num3) 
            {
                Console.WriteLine("num2 is greater");
            }
            else
            {
                Console.WriteLine("num3 is greater");
            }

        }
    }
}