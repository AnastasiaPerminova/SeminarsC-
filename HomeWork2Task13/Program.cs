// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите  число: ");
int number =Math.Abs( Convert.ToInt32(Console.ReadLine ()));

if (number < 100)
{
    Console.WriteLine($"В числе третьей цифры нет");
}
else if (number > 99 && number <1000)
{
    Console.WriteLine($"В числе третья цифра {number%10}");

}
else
{   do
    
    {
        number = number / 10;
    }
    while (number > 999);
       
    Console.WriteLine($"В числе третья цифра {number%10}");
}