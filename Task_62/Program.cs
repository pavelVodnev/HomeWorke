// Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int arraySizeX = 4;
int arraySizeY = 4;
int[,] testArray = new int[arraySizeX, arraySizeY];

FillArrayInSpiral(testArray);
PrintDoubleArray(testArray);

void FillArrayInSpiral(int[,] array)
{

    int posI = 0;
    int posJ = 0;
    bool isItNewCircle = true;

    for (int i = 0; i < array.Length; i++)
    {
        array[posI, posJ] = i + 1;

        if (posJ + 1 < array.GetLength(1) && isItNewCircle && array[posI, posJ + 1] == 0)
        {
            posJ++;
            continue;
        }
        else
        {
            isItNewCircle = false;
        }
        
        if (posI + 1 < array.GetLength(0) && array[posI + 1, posJ] == 0)
        {
            posI++;
            continue;
        }
        
        if (posJ - 1 >= 0 && array[posI, posJ - 1] == 0)
        {
            posJ--;
            continue;
        }
        
        if (posI - 1 >= 0 && array[posI-1, posJ] == 0)
        {
            posI--;
            continue;
        }
        else
        {
            posJ++;
            isItNewCircle = true;
        }
    }
}

void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}