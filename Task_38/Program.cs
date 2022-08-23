// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


int size = new Random().Next(5, 5);
Console.WriteLine("Массив вещественных чисел: ");

double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();

  
    Console.WriteLine($"Минимальное значение массива {arr.Min()}");
    Console.WriteLine($"Mаксимальное значение массива {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    Console.WriteLine();
    
}

PrintDiffMinMax(FillSourceArray(size));
Console.WriteLine();
