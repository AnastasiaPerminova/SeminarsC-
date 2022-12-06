// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.
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

for (int i = 0; i < m; i+=2)
{
    for (int j = 0;  j <n ; j+=2)
    {
        matrix[i,j] = matrix[i,j] * matrix[i,j];
    }
    
} 
for (int i = 0; i < m; i++)
{
    for (int j = 0;  j <n ; j++)
    {
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();  
} 
 Console.WriteLine();  

// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int [,] matrix1 = new int [m1,n1];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix1[i,j] = new Random().Next(0,11);
        Console.Write(matrix1[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for(int i = 0; i < m1; i++)
{
    for(int j = 0; j < n1; j++)
    {
        if(i % 2 == 0 && j % 2 == 0){
        matrix1[i,j] = matrix1[i,j] * matrix1[i,j];
        }
        Console.Write(matrix1[i,j] + " ");
    }
    Console.WriteLine();
}
