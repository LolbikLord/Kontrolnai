using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());
    string[] inputArray = new string[arrayLength];

    }
    static void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива:");
        array[i] = Console.ReadLine();
    }
}

}