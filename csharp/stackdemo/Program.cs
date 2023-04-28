using System.Collections;

namespace stackdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s=new Stack();
           
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(s.Count);
            s.Push("hello");
            Console.WriteLine($"the top element of stack is {s.Peek()}");
            Console.WriteLine(s.Contains(1));
            foreach(var i in s)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"the vlue removed is{s.Pop()}");
            Console.WriteLine("after popping");
            foreach(var i in s)
            {
                Console.WriteLine(i);
            }
        }
    }
}