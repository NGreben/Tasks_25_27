/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int number;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out number);
Console.Write($"{Sum(number)}");

int Sum(int _number)
{
    int sum = 0;
    if (_number % 10 == 0)
        sum = _number;
    else while (_number >= 10)
        {
            sum = sum + _number % 10; // 0+2
            _number = _number / 10;// 8
        }
    sum = sum + _number;
    return sum;
}
