// Задача 65. Задайте числа М и  N и выведите все натуральные числа от М до N.

void RoadToN (int max, int min)
{
    if( max < min)
    {
        return;
    }
    RoadToN(max - 1, min);
    Console.Write($"{max} ");
}

Console.WriteLine("Введите число max: ");
int numberMax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число min: ");
int numberMin = Convert.ToInt32(Console.ReadLine());
RoadToN(max:numberMax, min:numberMin);