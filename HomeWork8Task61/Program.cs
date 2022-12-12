// Задача 61. Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника.

// Треугольник Паскаля — форма записи биномиальных коэффициентов в виде бесконечной треугольной таблицы. 
// Элементы массива обозначаются C subscript n superscript k, где n — номер строки, 
// k — порядковый номер элемента в строке. Нумерацию строк начинают с нулевой, при этом нулевая строка — это вершина, то есть число 1. 
// Нумерацию чисел в строке также начинают с нуля и с левого края.

 //C n + 1 k + 1 = C n k + 1 + C n k

 int[,] PascalTriangle(int N)
 {
    int[,] triangle = new int [N,N+1];
    triangle[0,1] = 1;
  
    for (int i = 0; i < triangle.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < triangle.GetLength(1) - 1; j++)
        {
            triangle[i + 1, j + 1] = triangle[i, j + 1] + triangle[i,j];
        }
    }
    return triangle;
 }



void PrintTriangle(int[,] triangle)
{
    for (int i = 0; i < triangle.GetLength(0); i++)
    {   
        Console.Write(string.Concat(Enumerable.Repeat(" ",3*triangle.GetLength(0) - i)));
        
        for (int j = 0; j < triangle.GetLength(1); j++)
        {
            if (triangle[i, j] != 0)
            {
                Console.Write(triangle[i, j] + " ");
            }

        }
        Console.WriteLine();
        
    }
}

Console.WriteLine("Введите количество N выводимых строк треугольника Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] triangle =PascalTriangle(n);
PrintTriangle(triangle);