using System.ComponentModel.Design;

namespace vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a character");
            char ch1=Convert.ToChar(Console.ReadLine());
            if (ch1 == 'a' || ch1 == 'A' || ch1 == 'e' || ch1 == 'E' || ch1 == 'i' || ch1 == 'I' || ch1 == 'o' || ch1 == 'O' || ch1 == 'u' || ch1 == 'U')
            {
                Console.WriteLine("ch1 is a vowel");
            }
            else
                Console.WriteLine("ch1 is not a vowel");

            
        }
    }
}