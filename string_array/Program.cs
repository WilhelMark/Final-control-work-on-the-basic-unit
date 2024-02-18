using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через запятую и пробел:");
        string input = Console.ReadLine()!;
        string[] inputArray = input.Split(new string[] { ", " }, StringSplitOptions.None);
    }
}