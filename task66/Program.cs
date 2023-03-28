// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalSum (int min, int max)
{
    if( min == max)
    {
        return min;
    }
   return max + NaturalSum(min, max - 1);
}

Console.Write("Введите число min: ");
int numberMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число max: ");
int numberMax = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных чисел от {numberMin} до {numberMax} равна: {NaturalSum(max:numberMax, min:numberMin)}");

 
