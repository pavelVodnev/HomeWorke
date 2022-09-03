// Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int linesArray = 3;
int columsArray = 5;
int minNumber = 1;
int maxNumbewr = 9;
int[,] testArray = new int[linesArray, columsArray];

FillArrayRandomNumber(testArray, minNumber, maxNumbewr);
Console.WriteLine("Заданный массив");
PrintDoubleArray(testArray);
SortNumberInArray(testArray);
Console.WriteLine("Элементы в каждой строке упорядочены по убыванию");
PrintDoubleArray(testArray);

void FillArrayRandomNumber(int[,] array, int minNumber = 0, int maxNumber = 9)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(minNumber, maxNumber + 1);
        }
    }
}

void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortNumberInArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = j + 1; h < array.GetLength(1); h++)
            {
                if (array[i, j] < array[i, h])
                {
                    int tempNumber = array[i, j];
                    array[i, j] = array[i, h];
                    array[i, h] = tempNumber;
                }
            }
        }
    }
}