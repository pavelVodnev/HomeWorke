// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Первый способ:
// try
// {
//     Console.WriteLine("Введите число: ");
//     int n = int.Parse(Console.ReadLine());

//     if (n > 0)
//         for (int i = 1; i <= n; i++)

//             Console.WriteLine($"{i}\t{i * i * i}");

//     else Console.WriteLine("Неверное число!");
// }
// catch
// {
//     Console.WriteLine("Введен не известный символ:");
// }

// Второй способ:

try
{
    Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int i = 1;

    if (n > 0)
    {
        while (i <= n)
        {
            int q = i * i * i;
            i++;
            Console.WriteLine($"{i}    {q}");
        }
    }
    else
    {
        Console.WriteLine("Введено => 0");
    }
}
catch
{
    Console.WriteLine("Не верный символ!");
}
