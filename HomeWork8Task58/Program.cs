// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//  Результатом умножения матриц Am×n и Bn×k будет матрица Cm×k такая,
//  что элемент матрицы C, стоящий в i-той строке и j-том столбце (cij),
//  равен сумме произведений элементов i-той строки матрицы A на соответствующие элементы j-того столбца матрицы B:
// cij = ai1 · b1j + ai2 · b2j + ... + ain · bnj

// Замечание.Две матрицы можно перемножить между собой тогда и только тогда, когда количество столбцов первой матрицы равно количеству строк второй матрицы.

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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{   if(matrix1.GetLength(1) == matrix2.GetLength(0))
    { 
        int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    resultMatrix[i, j] = resultMatrix[i, j] + matrix1[i, k] * matrix2[k, j];
                }

            }
        }
        return resultMatrix;
    }
    else
    {
         return null;
    }

}


Console.WriteLine("Введите размерность первой матрицы m * n");
Console.Write("Введите m :");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n :");
int n1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = FillMatrix(m1, n1);


Console.WriteLine("Введите размерность второй матрицы m * n");
Console.Write("Введите m :");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n :");
int n2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = FillMatrix(m2, n2);

PrintMatrix(matrix1);
Console.WriteLine("-------------");
PrintMatrix(matrix2);
Console.WriteLine("-------------");

int[,] resultMatrix1 = MatrixMultiplication(matrix1, matrix2);
if (resultMatrix1 != null)
{
    PrintMatrix(resultMatrix1);
}
else 
{
     Console.WriteLine("Умножение невозможно");
}

Console.WriteLine("Проверка. Умножение матриц из примера:");
int[,] matrix3 = {{2 , 4},{3, 2}};
PrintMatrix(matrix3);
Console.WriteLine("--------");
int[,] matrix4 = {{3 , 4},{3, 3}};
PrintMatrix(matrix4);
Console.WriteLine("--------");
int[,] resultMatrix2 = MatrixMultiplication(matrix3, matrix4);
PrintMatrix(resultMatrix2);

