// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

Console.WriteLine();

int[,] matrix1 = new int[n,m];

for (int i = 0; i < n; i++)
{
    for (int j = 0;  j < m; j++)
    {
        matrix1[i,j] = matrix[j,i];
        Console.Write(matrix1[i,j] + " ");
    }
    Console.WriteLine();  
} 
 Console.WriteLine();

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = FillMatrix(m,n);
// PrintMatrix(matrix);
// Console.WriteLine();
// int [,] resultMatrix = new int[n,m];
//     for(int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             resultMatrix[i,j] = matrix[j,i];
//         }
//         Console.WriteLine();
//     }
// PrintMatrix(resultMatrix);
