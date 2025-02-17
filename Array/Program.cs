using System;
internal class Array
{
    private static int InputUser(string message, bool clear = false)
    {
        if (clear) Console.Clear();

        Console.WriteLine($"{message}");

        string? input = Console.ReadLine();

        int number = 0;
        bool success = int.TryParse(input, out number);

        if (success) return number;

        return InputUser(message, true);
    }

    private static int GetArrSize()
    {
        int size = InputUser("Digite a quantidade de elementos");

        if (size < 3 || size > 10)
        {
            Console.WriteLine("O numero deve ser maior que 3 e menor que 10!");

            return GetArrSize();
        }

        return size;
    }

    private static void PopulateArr(List<int> arr, int size)
    {
        for (int i = 0; i < size; i++)
        {
            arr.Add(InputUser("Digite um numero"));
        }
    }

    private static float GetAverage(List<int> arr)
    {
        float result = 0;

        foreach (int i in arr) result += i;

        return result / arr.Count;
    }

    private static void Main(string[] args)
    { 
        List<int> arr = new List<int>();
        int size = GetArrSize();

        PopulateArr(arr, size);

        float average = GetAverage(arr);

        Console.WriteLine($"\nMedia: {average}");
    }
}