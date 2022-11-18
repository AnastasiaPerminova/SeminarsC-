// Программа принимает координаты X, Y. X не равен 0, Y не равен 0.
//Выводит информацию, в какой четверти системы координат находится точка.

Console.WriteLine("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}
else
{
    Console.WriteLine("Точка находится координатной оси");
}
