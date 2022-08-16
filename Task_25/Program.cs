// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число которое надо возводить:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень в котрую возводим:");
int exponent = Convert.ToInt32(Console.ReadLine());

int GetExponentiation(int num, int exponent)
{
    int count = 1;
    int result = num;
    while (count < exponent)
    {
        result = result * num;
        count++;
    }
    return result;
}
int result = GetExponentiation(num, exponent);
Console.WriteLine($"чило -> {num} в натуральной степени-> {exponent} = {result}");
Console.WriteLine();
