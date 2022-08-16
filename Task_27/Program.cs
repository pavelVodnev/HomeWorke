// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// .....................................................1 Вариант

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int sumDigit = 0;
// Console.Write($"Сумма цифр числа {number} равна ");

// while (number > 0)
// {
//     int digit = number % 10;
//     sumDigit = sumDigit + digit;
//     number = number / 10;
// }

// Console.WriteLine(sumDigit);
// Console.WriteLine();

// ......................................2 Вариант 
Console.WriteLine("ВВедите число: ");
int num = System.Convert.ToInt32(Console.ReadLine());
int sum = default;//"default" можно использовать место 0.

for (int i = 1; i <= num; i++)//"i = 1" счетчик, "i++"изменения оператора.
{
    int digit = num % 10;
    sum = sum + digit;
    num = num / 10;

}
Console.WriteLine($"суммa цифр = {sum}");
