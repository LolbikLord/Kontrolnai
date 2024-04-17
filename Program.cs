using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());
        string[] inputArray = new string[arrayLength];
        FillArray(inputArray);
        
        string[] shortStringsArray = FilterShortStrings(inputArray);