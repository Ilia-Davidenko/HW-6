﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите пять чисел");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());

int sum = 0;

if (a > 0) sum = sum + 1;
if (b > 0) sum = sum + 1;
if (c > 0) sum = sum + 1;
if (d > 0) sum = sum + 1;
if (e > 0) sum = sum + 1;

Console.WriteLine($"Четных чисел {sum}");
