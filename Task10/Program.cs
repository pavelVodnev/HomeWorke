﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Решить без использования строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int n = System.Convert.ToInt32(Console.ReadLine());

int a = (n % 100) / 10;

Console.WriteLine($"Вторая цифра {a}");
