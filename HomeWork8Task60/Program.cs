// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillCube(int rows, int columns, int numbers)
{
    int[,,] cube = new int[rows, columns, numbers];
    int[] numberArray = new int[rows * columns * numbers];
    int count = 0;
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)

            {
                int tempNumb;
                do tempNumb = new Random().Next(10, 100);
                while (numberArray.Contains(tempNumb));
                cube[i, j, k] = tempNumb;
                numberArray[count] = cube[i, j, k];
                count++;

            }
        }
    }
    return cube;
}

void PrintCube(int[,,]cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)

            {
                 Console.Write(cube[i, j, k] + $"({i}, {j}, {k})" + "  ");
            }
        Console.WriteLine();        
        }
    
    }
}

Console.WriteLine("Введите размерность куба m * n * k");
Console.Write("Введите m :");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n :");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k :");
int k = Convert.ToInt32(Console.ReadLine());
int[, ,] cube = FillCube(m, n, k);
PrintCube(cube);