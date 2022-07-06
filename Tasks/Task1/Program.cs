// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] Array(int length = 6, int min = 100, int max = 999)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    int quanityNum = 0;;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        quanityNum++; 
    }
    
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество четных чисел = {quanityNum}");
}

PrintArray(Array());