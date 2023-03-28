﻿// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void RoadToN(int N)
{
    if(N == 0)
    {
        return;
    }
    RoadToN(N-1);
    Console.Write($"{N} ");
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadToN(number);

