﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine ()); 

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine ()); 


if (numberA > numberB )
{
       
    Console.WriteLine($"Большее число это {numberA}, а меньшее число это {numberB}");
}
else if (numberA == numberB)
{
    Console.WriteLine($"Числа равны");
}
else 
{
     Console.WriteLine($"Большее число это {numberB}, а меньшее число это {numberA}");
}

