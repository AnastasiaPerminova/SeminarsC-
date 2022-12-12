// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigits (int number)
{
    if (number == 0)
    {
        return 0;
    }
    return SumDigits(number/10) + number%10;
}


Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine($"В числе {number} cумма цифр равна  "  + SumDigits(number) +  ".");