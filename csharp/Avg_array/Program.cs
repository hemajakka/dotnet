namespace Avg_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[10];
            double sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            
            } 
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
            for(int i=0 ; i<arr.Length ; i++)
            {
                sum+= arr[i];
            }
            double avg=sum/arr.Length;
            Console.WriteLine(avg);

        }
    }
}