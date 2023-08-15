using System;

namespace InsertionSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 22,27,16,2,18,6};
            int n = sayilar.Length;

            InsertionSort(sayilar, n);
            PrintArray(sayilar);
        }

        static void PrintArray(int[] dizi)
        {
            foreach (int num in dizi)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        static void InsertionSort(int[] arr, int n)
        {
            int deger, j;
            for (int i = 1; i < n; i++)
            {
                deger = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > deger)
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }
                arr[j + 1] = deger;
            }
        }
    }
}
