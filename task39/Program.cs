// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}

void ReversArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
  
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 0;
int[] array = FillArray(num);
Console.WriteLine(string.Join(", ", array));
ReversArray(array);
Console.WriteLine(string.Join(", ", array));

// int[] newArray = array;
// array[0] = 100;
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(string.Join(", ", newArray));