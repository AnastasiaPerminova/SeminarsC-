// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string Numbers ( int m, int n)
{   
    if (m < n)
    {
        if( n == m) return $"{n} ";
        else  return Numbers(m, n - 1) + $"{n} ";
    }
    else 
    {
        if( n == m ) return $"{n} ";
        else  return Numbers(m, n + 1) + $"{n} ";
    }
}

Console.WriteLine("Введите M :");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N :");
int N= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Numbers(M,N));

void Rec(int n, int m)
{   
     if (m > n)
    {
        if( n == m) 
        {
            return;
        }
        Rec(n,m - 1);
        Console.Write($"{m} ");
    }
    else if (m < n)
    {
        if( n == m ) return;

       Rec(n, m + 1);
       Console.Write($"{m} ");
      
    }
    else Console.Write($"{m} ");
}

Console.WriteLine("Введите M :");
int M1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N :");
int N1= Convert.ToInt32(Console.ReadLine());
Rec(M1, N1);