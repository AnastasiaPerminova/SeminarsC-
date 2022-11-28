// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

if (array.Length % 2 == 0)
{
    int newNum = array.Length / 2;
    int[] newArray = new int[newNum];
    for (int i = 0; i < array.Length/2; i++)
    {
        newArray [i] = array[i] * array[array.Length - i -1];
    }
    Console.WriteLine(string.Join(", ", newArray));
}
else
{
    int newNum = array.Length / 2 + 1;
    int[] newArray = new int[newNum];
    for (int i = 0; i < array.Length/2; i++)
    {
        newArray [i] = array[i] * array[array.Length - i - 1];
    }
    newArray[newArray.Length - 1] = array[array.Length / 2];
    Console.WriteLine(string.Join(", ", newArray));
}

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] FillArray1(int size)
{
    
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] array1 = FillArray1(num1);
Console.WriteLine(string.Join(", ", array1));

int newLength = array1.Length % 2 + array1.Length/2;
int[] newArray1 = new int[newLength];
for(int i = 0; i < array1.Length/2; i++)
{
    newArray1[i] = array1[i] * array1[array1.Length-1-i];
}
if (array1.Length % 2 > 0)
{
    newArray1[newArray1.Length-1] = array1[array1.Length/2];
}
Console.WriteLine(string.Join(", ", newArray1));

