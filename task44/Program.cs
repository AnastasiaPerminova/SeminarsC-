// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine ());

int first = 0;
Console.Write(first + " ");

int second = 1;
Console.Write(second + " ");


for (int i = 3; i <= number; i++)
{   
    int temp = second;
    second = second + first;
    first = temp;
    Console.Write(second + " ");
}
Console.WriteLine();
void PrintFib(int n)
{if (n < 2)
    {
        Console.WriteLine("Ошибка");
    }
 else
    {
        Console.Write("0 1 ");
        int neighbour1 = 0;
        int neighbour2 = 1;
        int res = 0;
        for (int i = 0; i < n - 2; i++)
        {
            res = neighbour1 + neighbour2;
            Console.Write(res + " ");
            neighbour1 = neighbour2;
            neighbour2 = res;
        }
    }
}


PrintFib(number);