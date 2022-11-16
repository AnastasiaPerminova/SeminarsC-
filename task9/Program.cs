// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число {number}");
int digit1 = number/10;
int digit2 = number % 10;
if(digit1 > digit2)
{
    Console.WriteLine($"Наибольшая цифра в числе {number} это {digit1}");
}
else
{
    Console.WriteLine($"Наибольшая цифра в числе {number} это {digit2}");
}