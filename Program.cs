using System.ComponentModel.DataAnnotations.Schema;

namespace Reverse_All_Elements_of_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 10, 7, 9, 1, 3, 2, 5, 4, 6, 8 };
            PrintArray(ints);
            ReverseAllElementsInArray(ints);
            PrintArray(ints);

        }

        static void ReverseAllElementsInArray(int[] arr)
        {
            int n = arr.Length;
            
            for (int left = 0; left < n / 2; left++)
            {
                int right = n - 1 - left;
                SwapElementValues(arr, left, right);
            }
        }

        static void SwapElementValues(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
