// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    int count = 1;

    int countMax = rows * columns;


    for (int j = 0; j < columns; j++)
    {
        matrix[0, j] = count;

        count++;

    }

    for (int i = 1; i < rows; i++)
    {
        matrix[i, columns - 1] = count;
        count++;
    }
    columns = columns - 1;

    for (int j = 0; j < columns; j++)
    {
        matrix[rows - 1, columns - 1- j] = count;
        count++;
    }
    rows = rows - 1;

    for (int i = 1; i < rows; i++)
    {
        matrix[rows - i, 0] = count;
        count++;
    }

    for (int j = 1; j < columns; j++)
    {
        matrix[1, j] = count;
        count++;
    }

    for (int i = 2; i < rows; i++)
    {
        matrix[i, columns - 1] = count;
        count++;
    }
    columns = columns - 1;

    for (int j = 1; j < columns; j++)
    {
        matrix[rows - 1, columns - j] = count;
        count++;
    }
    rows = rows - 1;

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Размерность матрицы m * n = 4 * 4.");
int m = 4;
int n = 4;
int[,] matrix = FillSpiralMatrix(m, n);
PrintMatrix(matrix);