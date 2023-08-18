using System;

class MergeSort
{
    private int[] list;

    public MergeSort(int[] listToSort)
    {
        list = listToSort;
    }

    public int[] GetList()
    {
        return list;
    }

    public void Sort()
    {
        list = Sort(list);
    }

    private int[] Sort(int[] whole)
    {
        if (whole.Length == 1)
        {
            return whole;
        }
        else
        {
            int[] left = new int[whole.Length / 2];
            Array.Copy(whole, 0, left, 0, left.Length);

            int[] right = new int[whole.Length - left.Length];
            Array.Copy(whole, left.Length, right, 0, right.Length);

            left = Sort(left);
            right = Sort(right);

            Merge(left, right, whole);

            // Adım adım çıktıları ekrana yazdırma
            Console.Write("Merged: ");
            foreach (int num in whole)
                Console.Write(num + " ");
            Console.WriteLine();

            return whole;
        }
    }

    private void Merge(int[] left, int[] right, int[] result)
    {
        int x = 0;
        int y = 0;
        int k = 0;

        while (x < left.Length && y < right.Length)
        {
            if (left[x] < right[y])
            {
                result[k] = left[x];
                x++;
            }
            else
            {
                result[k] = right[y];
                y++;
            }
            k++;
        }

        int[] rest;
        int restIndex;
        if (x >= left.Length)
        {
            rest = right;
            restIndex = y;
        }
        else
        {
            rest = left;
            restIndex = x;
        }

        for (int i = restIndex; i < rest.Length; i++)
        {
            result[k] = rest[i];
            k++;
        }
    }

    static void Main(string[] args)
    {
        int[] arrayToSort = { 16, 21, 11, 8, 12, 22 };

        Console.WriteLine("Unsorted:");
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            Console.Write(arrayToSort[i] + " ");
        }
        Console.WriteLine();

        MergeSort sortObj = new MergeSort(arrayToSort);
        sortObj.Sort();

        Console.WriteLine("Sorted:");
        int[] sirali = sortObj.GetList();
        for (int i = 0; i < sirali.Length; i++)
        {
            Console.Write(sirali[i] + " ");
        }
        Console.WriteLine();
    }
}
