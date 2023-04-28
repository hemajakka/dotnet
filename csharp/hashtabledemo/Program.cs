using System.Collections;

namespace hashtabledemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Hashtable ht = new Hashtable();
            ht.Add(4, "four");
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(5, "five");
            ht.Add(3, "three");
            foreach(var i in  ht.Keys)
            {
                Console.WriteLine($" {i}:{ht[i]}");
            }
            ht.Remove(1);
            Console.WriteLine("after removing");
            foreach(var i in ht.Keys)
            {
                Console.WriteLine($"{i} : {ht[i]}");
            }

        }
    }
}