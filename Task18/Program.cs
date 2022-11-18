//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти : ");
int number = Convert.ToInt32(Console.ReadLine ());

switch (number)
{    case 1:
        Console.WriteLine("Первая четверть: x > 0 и y > 0");
        break;
    
    case  2:
       Console.WriteLine("Вторая четверть: x < 0 и y > 0");
        break;
    
    case  3:
        Console.WriteLine("Третья четверть: x < 0 и y < 0");
        break;

    case 4:
       Console.WriteLine("Четвертая четверть: x > 0 и y < 0");
        break;
    default:
        Console.WriteLine(" Номер должен быть от 1 до 4.Четвертей всего 4! ");
        break;
}   



if(number == 1)
{
     Console.WriteLine("Первая четверть: x > 0 и y > 0");
}       
else if (number == 2)

{
     Console.WriteLine("Вторая четверть: x < 0 и y > 0");
}  
else if (number == 3)

{
    Console.WriteLine("Третья четверть: x < 0 и y < 0");
}
else if (number == 4)
{
    Console.WriteLine("Четвертая четверть: x > 0 и y < 0");
}
else 
{   Console.WriteLine(" Номер должен быть от 1 до 4.Четвертей всего 4! ");
    
}   

string[]quarters ={"x > 0 и y > 0",//0
                   "x < 0 и y < 0",//1
                   "x < 0 и y < 0",//2
                   "x > 0 и y < 0"//9


};
if(number>=1 && number<=4)
{
        Console.WriteLine(quarters[number-1]);
}
else
{
    Console.WriteLine("Такой четверти нет");
}