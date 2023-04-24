namespace largestnum_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr=new int[] {7,4,5,6,8,2,3,1};
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] > arr[0])
                {
                    arr[0] = arr[i];
                }
            }
            Console.WriteLine($"largest number is {arr[0]} ");
        }
    }
}