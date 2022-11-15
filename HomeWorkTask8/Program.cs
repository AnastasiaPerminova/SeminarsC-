//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число : ");
int numberA = Convert.ToInt32(Console.ReadLine ()); 

if(numberA <=1)
{
Console.WriteLine("Выводятся только чётные числа в промежутке от 1. Введите число больше 1.");

}

for (int i = 2; i <=numberA; i = i + 2)
{
    Console.Write(i + " ");
}