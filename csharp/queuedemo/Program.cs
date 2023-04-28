using System.Collections;

namespace queuedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Peek();
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);    
            }
            Console.WriteLine($"the top element is {q.Peek()}");
        }
    }
}