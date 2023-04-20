namespace switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1");
            int n1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter num2");
            int n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter operator");
            char op=Convert.ToChar(Console.ReadLine()); 
            switch(op)
            {
                case '+':
                    {
                        Console.WriteLine(n1+n2);
                        break;
                    }
                case '-':
                    { Console.WriteLine(n1-n2);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(n1 * n2);
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(n1 / n2);
                        break;
                    }
                case '%':
                    {
                        Console.WriteLine(n1 % n2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("please enter correct operator");
                        break;
                    }
            }

        }
    }
}