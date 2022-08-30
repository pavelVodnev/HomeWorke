// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// ............................................1 вариант решения

// int volume = 6;
// int count = 0;

// while (volume > 0)
// {
//     Console.Write("Введите число:   ");
//     string num = Console.ReadLine();
//     int number = Convert.ToInt32(num);
//     if (number > 0) count++;
//     volume--;
// }

// Console.WriteLine($"Количество чисел больше 0 = {count}");

// ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,2 вариант

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во чисел больше -> 0 = {count}");

// ,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,3 вариант в интернете нашел
// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = arr.Count(x => x > 0);
// Console.WriteLine($"Кол-во чисел > 0 = {count}");
