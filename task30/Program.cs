// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
            collection[index] = new Random().Next(0, 2);
            index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}
int[] array = new int[8];
 
FillArray(array);
PrintArray(array);

Console.WriteLine();

int [] arr = new int [8]; 
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 2);
    Console.Write(" " + arr[i]);
}
Console.WriteLine();

Console.Write('[' + string.Join(", ", arr) + ']');

Console.WriteLine();

int[] arr1 = new int [5];
for(int i = 0; i < arr1.Length; i++)
{

    Console.WriteLine("Введите элемент массива");

    arr1[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(", ", arr1));

void Enter(out int A, out int B)
{
    Console.Write("Ведите число А: ");
     A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите число B: ");
    B = Convert.ToInt32(Console.ReadLine());
}



Enter(out int A, out int B);
Console.WriteLine($"{A} {B}");
