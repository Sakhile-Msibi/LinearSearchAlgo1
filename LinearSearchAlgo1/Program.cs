using System;

namespace LinearSearchAlgo1
{
    class Program
    {
        static int GetSum(int[] arr, int n)
        {
            if (n % 2 == 0)
                return 0;

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int n1 = arr1.Length;
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int n2 = arr2.Length;

            Console.WriteLine("Hello World!");

            Console.WriteLine(GetSum(arr1, n1));
            Console.WriteLine(GetSum(arr2, n2));
        }
    }
}
