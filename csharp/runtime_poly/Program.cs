namespace runtime_poly
{
    class person
    {
        public virtual void show()
        {
            Console.WriteLine("this is show method of person class");
        }
    }
    class student : person
    {
        public override void show()
        {
            Console.WriteLine("this  is show method of student class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new student();
            p.show();
        }
    }
}