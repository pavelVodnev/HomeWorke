// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

// Один из способов 
// try
// // {
//     Console.Write("Введите первые координаты точки для X : ");
//     int x1 = int.Parse(Console.ReadLine() );
//     Console.Write("Введите первые координаты точки для Y : ");
//     int y1 = int.Parse(Console.ReadLine());
//     Console.Write("Введите первые координаты точки для Z : ");
//     int z1 = int.Parse(Console.ReadLine());

//     Console.Write("Введите координаты второй точки для X : ");
//     int x2 = int.Parse(Console.ReadLine());
//     Console.Write("Введите координаты второй точки для Y : ");
//     int y2 = int.Parse(Console.ReadLine());
//     Console.Write("Введите координаты второй точки для Z : ");
//     int z2 = int.Parse(Console.ReadLine());

//     double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
//     Console.WriteLine("Расстояние между точками равно {0: #.##}", result);
// // }
// catch
// {
//     Console.WriteLine("Не верный символы!");
// }

// Второй пример

double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    // double result = Math.Sqrt((xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1) + (zc2 - zc1) * (zc2 - zc1)); // можно заменить одной строчкой
    // return result;                                                                                                // ^
    return Math.Sqrt((xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1) + (zc2 - zc1) * (zc2 - zc1));
}
Console.WriteLine("1 точка ");
Console.Write("Введите координату X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2 точка ");
Console.Write("Введите координату X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1, y1, x2, y2, z1, z2);
Console.WriteLine(Math.Round(res, 2));
