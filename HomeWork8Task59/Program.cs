// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность первой матрицы m * n");
Console.Write("Введите m :");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n :");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);

int min = matrix[0, 0];
int iX = 0;
int jX = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            iX = i;
            jX = j;
        }
    }
}
Console.WriteLine("--------");
Console.WriteLine("Наименьший элемент массива равен " + min);


Console.WriteLine("min i = " + iX + " min j = " + jX);
Console.WriteLine("--------");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == iX || j == jX)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(matrix[i,j]+ " ");
            Console.ResetColor();
               
        }
        else 
        {
                Console.Write(matrix[i,j]+ " ");
        }
    }
    Console.WriteLine();  
}
    
Console.WriteLine("--------");

int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
int k = 0;
int l = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i < iX) k = i;

    if (i > iX) k = i - 1;

    if (i == iX) continue;
   
    for (int j = 0; j < matrix.GetLength(1); j++)

    {
        if (j < jX) l = j;
       
        if (j > jX) l = j - 1;
      
        if (j == jX) continue;
       
        newMatrix[k, l] = matrix[i, j];
    }
}


PrintMatrix(newMatrix);