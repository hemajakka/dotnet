using System.Collections;

namespace Arraylistdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add("hello");
            list.Add(2.5f);
            list.Add(true); list.Add(false);
            if(list.Contains(4)) 
            {
                Console.WriteLine("value is already present");
            }
            else
            {
                list.Add(4);
            }
            list.Insert(3, "world");
            list.Remove(4);
            list.RemoveAt(3);
            
           
            list.Add(list.Count);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("after reversing");
            list.Reverse();
            foreach(var v in list)
            {
                Console.WriteLine(v);
            }


        }
    }
}