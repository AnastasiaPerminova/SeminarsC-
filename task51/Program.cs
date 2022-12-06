// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


Console.WriteLine("Введите размерность двумерного массива m * n");
Console.Write("Введите m :");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n :");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];
int SumDiag = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0;  j <n ; j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j] + " ");
        if( i == j) SumDiag = SumDiag + matrix[i,j];
    }
    Console.WriteLine();  
} 
 Console.WriteLine($" Сумма элементов главной диагонали равна {SumDiag}.");