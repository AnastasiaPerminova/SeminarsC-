// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите заданный номер от 1 до 7: ");
int NumDay = Convert.ToInt32(Console.ReadLine ()); 
if (NumDay < 1 || NumDay > 7)
{
        Console.WriteLine("Ошибка ввода. Номер должен быть от 1 до 7. Дней недели всего 7!");
}
else if (NumDay == 6 || NumDay == 7)
{
    Console.WriteLine("Да! Ура! Выходной!");
}      
else
{
    Console.WriteLine("Нет! Ждём выходных!");
}

