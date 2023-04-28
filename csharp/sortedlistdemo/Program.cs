using System.Collections;

namespace sortedlistdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s=new SortedList();
            s.Add(1, "one");
            s.Add(3, "three");
            s.Add(2, "two");
            s.Add(5, "five");
            s.Add(4, "four");
            Console.WriteLine(s[3]);
            Console.WriteLine(s.GetKey(2));
            foreach (var i in s.Keys)
            {
                Console.WriteLine($" {i} : {s[i]}");
            }
        }
    }
}