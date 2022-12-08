// Задача 53: Задайте двумерный массив.
//  Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

  for (int j = 0;  j <n ; j++)
    
    {   
        int temp = matrix[0, j];
        matrix[0,j] = matrix[m-1,j];
        matrix[m-1, j] = temp;
      
    }
    
    for (int i = 0; i < m; i++)
{
    for (int j = 0;  j <n ; j++)
    {
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();  
} 

// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность двумерного массива m * n");
Console.Write("Введите m :");
int m1 = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
int [,] matrix1 = FillMatrix(m1,n1);
Console.Write("Введите n :");

PrintMatrix(matrix1);
Console.WriteLine();

for(int j = 0; j < matrix1.GetLength(1); j++)
{
    int temp = matrix1[0, j];
    matrix1[0,j] = matrix1[matrix1.GetLength(0)-1,j];
    matrix1[matrix1.GetLength(0)-1,j] = temp;
}

PrintMatrix(matrix1);
