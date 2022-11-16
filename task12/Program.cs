// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine ()); 

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine ()); 

int fraction = number2 % number1;

if (fraction == 0)
{
    Console.WriteLine(" Второе число является кратным первому.");
}
else
{
    Console.WriteLine($" Второе число не кратно первому. Остаток {fraction}");
}
