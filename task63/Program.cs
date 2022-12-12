// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string Numbers ( int n)
{
    if( n == 1 ) return $"{n} ";
    else  return Numbers(n - 1) + $"{n} ";
}
Console.WriteLine("Введите n :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numbers(n));

int count = 0;

void Numbers1 (int num)
{   
    if (num == 0)
    {
        return;
    }
    
    Numbers1(num - 1);
    Console.Write($"{num} ");
}
Console.WriteLine("Введите n :");
int n1= Convert.ToInt32(Console.ReadLine());
Numbers1(n1);