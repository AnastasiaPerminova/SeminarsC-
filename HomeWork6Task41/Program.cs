// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void GreaterThanZero(int num)
{   
    int[] array = new int[num];
    int count = 0;
   
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i+1}е число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
        if(number > 0) count++;  
    }
    Console.WriteLine("Были введены числа " + string.Join(", ", array) + ".");
    Console.WriteLine($"Введено чисел больше 0: {count}.");
}

Console.WriteLine("Введите количество чисел M: ");
int num = Convert.ToInt32(Console.ReadLine());
GreaterThanZero(num);