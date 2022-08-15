// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первый вариант: подсмотрел в интернете, для общего развитияюЯ так понимаю знесь на буквы и цифры.

// System.Console.WriteLine("Введите текст или число:");
// string writeTxt = Console.ReadLine();
// string txtToCheck = writeTxt.ToLower().Replace(" ",""); // для проверки переводим знаки в нижний регистр и убираем пробелы
// int length = txtToCheck.Length;
// string result = "не является";

// bool IsPalindrome(string p)
// {
//     int count = 0;
//     while (count <= length)
//     {
//         if (txtToCheck[count] != txtToCheck[length - 1]) return false;
//         length--;
//         count++;
//     }
//     return true;
// }

// if (IsPalindrome(txtToCheck)) result = "является";
// Console.WriteLine($"Введенное значение {result} палиндромом");


// Второй вариант решения: мне больше нравиться

Console.Write("Введите число: ");
string? number = Console.ReadLine();
try
{
    void CheckingNumber(string number)
    {
        if (number[0] == number[4] || number[1] == number[3])
        {
            Console.WriteLine($"Число-> {number} -> палиндром.");
        }
        else Console.WriteLine($"Число-> {number} -> НЕ палиндром.");
    }

    if (number!.Length == 5)
    {
        CheckingNumber(number);
    }
    else Console.WriteLine($"Введино не верное число!");
}

catch { Console.WriteLine("Не верный символы!"); }