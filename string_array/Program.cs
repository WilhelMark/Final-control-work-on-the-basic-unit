using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через запятую и пробел:");
        string input = Console.ReadLine()!;
        string[] inputArray = input.Split(new string[] { ", " }, StringSplitOptions.None);
        string[] outputArray = new string[inputArray.Length];
        int outputIndex = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                outputArray[outputIndex] = inputArray[i];
                outputIndex++;
            }
        }
        Array.Resize(ref outputArray, outputIndex);
        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", outputArray));
    }
}
