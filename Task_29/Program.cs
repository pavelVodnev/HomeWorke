// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//................................................................... 1 Решение

// int[] NewArray()
// {
//     int[] array = new int[8];// создали новый массив
//     for (int i = 0; i <= 7; i++)
//     {
//         array[i] = new Random().Next(1, 99);
//     }
//     return array;
// }
// int[] array = NewArray();
// void PrintArray()
// {
//     Console.Write("[");
//     for (int i = 0; i <= 7; i++)
//     {
//         Console.Write($" {array[i]}, ");
//     }
//     Console.Write("]");
// }
// PrintArray();

//.................................................................. 2 Решение
// void MasRandom(int[] array)
// {
//     Random md = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = md.Next(1, 99);
//     }
// }

// void ShowArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     { 
//         if (i < array.Length-1) Console.Write(array[i] + ",");
//         else Console.Write(array[i]);
//     }
//     Console.Write("]");
// }

// Console.WriteLine("Вывод массива:");
// int[] mas = new int[8];
// MasRandom(mas);
// ShowArray(mas);

// .......................................................3 решение

int n = 8;
int[] SetArray(int x)
{
    int[] arr = new int[x];

    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 99);

    }

    return arr;
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)

        Console.Write($"{array[i]}, ");

}


PrintArray(SetArray(n));