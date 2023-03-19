/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int A, B;

Console.Write($"Введите число А: ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write($"Введите число B: ");
int.TryParse(Console.ReadLine()!, out B);

Console.Write($"{Exponent(A, B)}");

int Exponent(int _A, int _B)
{
    int multiply = 1;
    for (int i = 1; i != _B + 1; i++)
        multiply = multiply * _A;
    return multiply;
}