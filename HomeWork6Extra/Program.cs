// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

int Digits(int number)
{   if(number == 0)
    {   
        return 0;
    }
    return Digits(number/10) + 1;
   
}
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine($"В числе {number} " + " - " + Digits(number) +  " цифр.");