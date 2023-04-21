namespace iterative_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, i;
            Console.WriteLine("enter a 5 digit number");
            n=Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                i = n % 10;
                sum = sum + i;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}