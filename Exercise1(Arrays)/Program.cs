using System;

namespace Exercise1_Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            var result = Arrays.Accumulate(arr);
            foreach(var element in result)
            {
                Console.WriteLine(element);
            }

        }
    }
}
