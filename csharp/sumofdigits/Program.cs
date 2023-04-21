namespace sumofdigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, m;
            Console.WriteLine("enter 5 digit");
            n=Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine($" sum is {sum}");
        }
    }
}