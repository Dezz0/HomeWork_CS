﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumOfNaturalNumbers(int m, int n)
{
    if (m == n)  return n;
    return m + GetSumOfNaturalNumbers(m + 1, n);
}

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = GetSumOfNaturalNumbers(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}: {sum}");

GetSumOfNaturalNumbers(m, n);