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
    Console.WriteLine("Массив строк, длина которых меньше либо равна 3 символа:");
    PrintArray(shortStringsArray);


    }
    static void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива:");
        array[i] = Console.ReadLine();
    }
}
    static string[] FilterShortStrings(string[] array)
{
    int shortStringsCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortStringsCount++;
        }
    }

    string[] shortStringsArray = new string[shortStringsCount];
    int currentIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortStringsArray[currentIndex] = array[i];
            currentIndex++;
        }
    }

    return shortStringsArray;
}
    static void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}'");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}


}