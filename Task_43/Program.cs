// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// .....................................................................1 Вариант

// Console.Write("Введите число для b1: ");
// string b1 = Console.ReadLine();
// Console.Write("Введите число для k1: ");
// string k1 = Console.ReadLine();
// Console.Write("Введите число для b2: ");
// string b2 = Console.ReadLine();
// Console.Write("Введите число для k2: ");
// string k2 = Console.ReadLine();

// void ExceptionHandling(string a1, string a2, string c1, string c2)
// {
//     bool yesInt = double.TryParse(a1, out double d1);
//     bool yesInt1 = double.TryParse(a2, out double d2);
//     bool yesInt2 = double.TryParse(c1, out double f1);
//     bool yesInt3 = double.TryParse(c2, out double f2);

//     if (yesInt && yesInt1 && yesInt2 && yesInt3)
//     {
//         double x = (f2 - f1) / (d1 - d2);
//         double y = ((f2 * d1) - (f1 * d2)) / (d1 - d2);
//         Console.WriteLine($" x = {x:F1}; y = {y:F1} ");
//         Console.BackgroundColor = ConsoleColor.Black;
        
//     }
//     else
//     {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.Write($"{a1}, {a2}, {c1}, {c2}");
//         Console.WriteLine(" -> Некорректный ввод!");
//     }
// }
// ExceptionHandling(k1, k2, b1, b2);

// ..................................................2 вариант в инетернете посмотрел(оно для себя,для развития)

Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
