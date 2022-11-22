// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Вариант для  числа с незаданным количеством знаков. 

Console.WriteLine("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine ());
List<int>digits = new List<int>();
int changedNumber = number;
do
{
    int digit = changedNumber % 10;
    changedNumber = changedNumber / 10;
    digits.Add(digit); 
}
while (changedNumber > 0);

for (int k = 0; k < digits.Count(); k++)
{
    if (digits[k] != digits[digits.Count() - k - 1])
    {
        Console.WriteLine("Число не является палиндромом.");
        break;
    }
    if (k == digits.Count() - 1)
    {
         Console.WriteLine("Число является палиндромом.");
    }

}



