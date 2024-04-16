using System;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Wprowadź rozmiar tablicy:");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100);
        }

        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(array);

        SelectionSortAlgorithm(array);

        Console.WriteLine("Tablica po sortowaniu:");
        PrintArray(array);
    }

    static void SelectionSortAlgorithm(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
