// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 5;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
        else uneven++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел {even}, нечетных чисел {uneven}");
    Console.WriteLine();
}

PrintResult(FillArray(size));