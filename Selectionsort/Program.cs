using System;

class Program
{
    public static int[] SelectionSort(int[] A, int n)
    {
        int tmp;
        int min;

        for (int i = 0; i < n - 1; i++)
        {
            min = i;

            for (int j = i; j < n; j++)
            {
                if (A[j] < A[min])
                {
                    min = j;
                }
            }

            tmp = A[i];
            A[i] = A[min];
            A[min] = tmp;

            // Adım adım çıktıları ekrana yazdırma
            Console.Write("Adım " + (i + 1) + ": ");
            foreach (int num in A)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        return A;
    }

    static void Main(string[] args)
    {
        int[] arr = { 7,3,5,8,2,9,4,15,6 };
        int n = arr.Length;

        Console.WriteLine("Başlangıç Dizisi:");
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();

        SelectionSort(arr, n);

        Console.WriteLine("Sıralanmış Dizi:");
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
