// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите  количество элементов в массиве : ");
int number = Convert.ToInt32(Console.ReadLine ());
int[] array = new int [number];
for (int i = 0; i < number; i++)
{   
    Console.WriteLine($"Введите {i + 1}-е число  в массив : ");
    int element = Convert.ToInt32(Console.ReadLine ());
    array [i] = element;

}

Console.Write('[' + string.Join(", ", array) + ']');