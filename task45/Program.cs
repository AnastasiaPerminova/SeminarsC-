// Задача 45: Напишите программу, 
// которая будет создавать копию заданного массива
//  с помощью поэлементного копирования.

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(num);
Console.WriteLine(string.Join(", ", array));

int[] NewArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    NewArray[i] = array[i];
}

array[0] = 4;
Console.WriteLine(string.Join(", ", NewArray));
Console.WriteLine(string.Join(", ", array));

