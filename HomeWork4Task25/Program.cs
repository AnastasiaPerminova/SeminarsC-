// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите  число А : ");
int A = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("Введите натуральное число B: ");
int B = Convert.ToInt32(Console.ReadLine ());

if (B < 1) 
{
    Console.WriteLine("Число B должно быть натуральным!");
}

else
{   
    int pow = A;
    for (int i = 1; i < B; i++)
    {
        pow = pow * A ;
    }
    Console.WriteLine($"Число {A}, возведенное в степень {B}, равно {pow}. ");
}
