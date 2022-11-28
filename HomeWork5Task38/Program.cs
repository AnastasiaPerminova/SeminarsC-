// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * new Random().Next(-10, 11), 2);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = FillArray(num);
Console.WriteLine(string.Join(", ", array));

double maxArray = array[0];
double minArray = array[0];

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > maxArray) maxArray = array[i];
    if(array[i] < minArray) minArray = array[i];
}
Console.WriteLine($"Максимальный элемент массива равен {maxArray}");
Console.WriteLine($"Минимальный элемент массива равен {minArray}");

double diff = maxArray - minArray;

Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diff}");