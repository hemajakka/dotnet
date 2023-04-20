namespace grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter student id");
            int id=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter student name");
            string name=Console.ReadLine();
            Console.WriteLine("enter student age");
            int age=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter marks1");
            double m1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter marks2");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter marks3");
            double m3 = Convert.ToDouble(Console.ReadLine());
            double score = Convert.ToDouble(m1 + m2 + m3);
            double percentage;
            percentage = (score / 300) * 100;
            Console.WriteLine("your score is" + score);
            Console.WriteLine("Your percentage is" + percentage);
            if (percentage > 50)
            {
                Console.WriteLine("your result for the score is pass");

                if (percentage >= 90 && percentage <= 100)
                {
                    Console.WriteLine("your grade is A");
                }
                if (percentage >= 80 && percentage <= 89)
                {
                    Console.WriteLine("your grade is B");
                }
                else if (percentage >= 60 && percentage <= 79)
                {
                    Console.WriteLine("your grade is C");

                }
                else if (percentage >= 50 && percentage <= 59)
                {
                    Console.WriteLine("your grade is D");

                }
            }
            else
            {
                Console.WriteLine("your result for the score is fail");
                Console.WriteLine("your grade is E");
            }

            

        }
    }
}