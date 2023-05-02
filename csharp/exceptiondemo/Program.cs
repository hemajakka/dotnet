namespace exceptiondemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c=0;
            
            try
            {
                Console.WriteLine("enter a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter b");
                b = Convert.ToInt32(Console.ReadLine());
                if(a<b)
                {
                    throw new IncorrectValueException("the first number cannot be less than second number");
                }
                c = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("you cant divide a number by 0");

            }
            catch(FormatException)
            {
                Console.WriteLine("you can not enter a string");
            }
            catch (IncorrectValueException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("something went wrong");
            }
            Console.WriteLine(c);

        }
    }
}