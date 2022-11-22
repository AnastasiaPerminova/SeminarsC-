// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }   
    return(sum);
    
}



Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("Сумма чисел равна " + Sum(A));

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("Сумма чисел равна " + Sum(B));
// int sum = 0;
// for (int i = 1; i <= A; i++)
// {   
//     sum = sum + i;
// }

// Console.WriteLine("Сумма чисел равна " + sum);

