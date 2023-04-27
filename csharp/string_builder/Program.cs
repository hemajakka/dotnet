namespace string_builder
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("welcome");
            sb.Append("to the c sharp programming");
            sb.Insert(15, "new");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
        }
    }
}