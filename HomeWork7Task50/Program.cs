// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
        matrix[i,j] = new Random().Next(-10, 11);
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();  
}

Console.WriteLine("Введите позиции элемента в двумерном массиве [i,j] :");
Console.Write("Введите i :");
int Xi = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j :");
int Xj = Convert.ToInt32(Console.ReadLine());

if(Xi >= 0 && Xi < m && Xj >=0 && Xj < n)
{  
    for (int i = 0; i < m; i++)
    {
        for (int j = 0;  j <n ; j++)
        {
            if (i == Xi && j == Xj)  
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(matrix[i,j] +"\t");
                Console.ResetColor();
            }
            else 
            {
                Console.Write(matrix[i,j]+"\t");
                }
        }
        Console.WriteLine();  
    }
}   
else
{
    Console.WriteLine("Такого элемента в массиве нет.");
    
}
    
