// Задача 46: Задайте двумерный массив размером m×n,
//  заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine("Введите размерность двумерного массива m * n");
Console.Write("Введите m :");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n :");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0;  j <n ; j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();  
} 

