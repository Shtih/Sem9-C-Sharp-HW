// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if(m >0 && n > 0)
    {
        return Akkerman(m-1, Akkerman(m,n - 1));
    }
        else if(m > 0 && n == 0)
        {
            return Akkerman(m-1,1);
        }
            else
            {
                return n + 1;
            }
}
Console.Write("Введите число М: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана {Akkerman(numberM, numberN)}");


