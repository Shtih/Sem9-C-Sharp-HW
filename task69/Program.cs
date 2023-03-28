//Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int AinGrabeB(int A, int B)
{
    if(B==0)
    {
        return 1;
    }
    return A = A * AinGrabeB(A, B -1); // A* = AinGrabeB(A, B -1)
}

  Console.WriteLine("Введите число A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите число B: ");
  int B = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine(($"{A} в степени {B} = {AinGrabeB(A, B)}"));

