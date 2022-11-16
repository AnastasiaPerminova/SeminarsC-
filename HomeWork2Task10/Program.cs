//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine ()));

if (number < 100 || number > 999)
{   
    Console.WriteLine("Только трехзначное число! ");
}
else 
{   
    int digit1 = number / 100;
    int digit2 =(number - digit1*100)/10;
    Console.WriteLine($"Вторая цифра числа {number} это {digit2}");
}
