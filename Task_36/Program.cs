// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 4;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int sum = 0;

    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + "  ");
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine("]");
    Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");

}
PrintArray(FillArray(size));
