// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine ());
int ChangedNumber = number;
int sum = 0;
if (ChangedNumber > 0)
{ 
    while (ChangedNumber > 0)
    {
        int digit = ChangedNumber % 10;
        ChangedNumber = ChangedNumber / 10;
        sum = sum + digit;

    }    

}
else
{
    ChangedNumber = Math.Abs(ChangedNumber);
    while (ChangedNumber > 10)
    {
        int digit = ChangedNumber % 10;
        ChangedNumber = ChangedNumber / 10;
        sum = sum + digit;

    }    
    int digit1 = ChangedNumber % 10;
    sum = sum - digit1;

}

Console.WriteLine("Сумма всех цифр в числе равна " + sum + ".");
