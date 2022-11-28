// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

Console.WriteLine("Введите искомое число: ");
int find = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < array.Length; i++ )
{   if (array[i] == find)
    {
        Console.WriteLine("Заданное число есть в массиве.");
        break;
    }
    else if (i == array.Length - 1)
    {
        Console.WriteLine("Заданного числа в массиве нет.");
    }
}


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool isOk = false;
for(int i = 0; i < array1.Length; i++)
{
    if(number1 == array1[i])
    {
        isOk = true;
        break;
    }
}
if(isOk)
{
    Console.Write("Элемент найден");
}
else
{
    Console.Write("Элемент не найден");
}
