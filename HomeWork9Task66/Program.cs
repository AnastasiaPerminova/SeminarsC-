// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int m, int n)
{
    if (m < n)
    {
        if (m == n) return m;
        else return SumNumbers(m + 1, n) + m;
    }
    else
    {
        if (n == m) return n;
        else return SumNumbers(m, n + 1) + n;
    }
}

Console.WriteLine("Введите M :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n} равна {SumNumbers(m, n)}.");