//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] Array()
{
    double[] array = new double[5];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 10;
    }
    return array;
}

void PrintArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
        System.Console.Write($"{array[i]}  ");
    }
    double difference = max - min;
    System.Console.WriteLine();
    System.Console.WriteLine($"Минимальное значение - {min}, максимальное значение - {max}");
    System.Console.WriteLine($"Разница между ними равна {difference}");
    System.Console.WriteLine();
}

PrintArray(Array());
