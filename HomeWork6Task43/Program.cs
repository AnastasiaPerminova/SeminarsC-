// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Даны функции y= k1x +b1 и y= k2x +b2 .Еслиk1= k2, то графики параллельны; Если k1и k2 не равны, то графики пересекаются.
//x0 = ((b2 - b1)/(k1 - k2)); y0 = (k1b2 - k2b1)/(k1-k2)
// 

void CrossPoint(double k1, double k2, double b1, double b2)
{
    if (k1 == k2) 
    {
        Console.WriteLine("Данные прямые параллельны, у них нет точек пересечения.");
    }
    else
    {
        double X0 = ((b2 - b1)/(k1 - k2));
        double Y0 = (k1*b2 - k2*b1)/(k1-k2);
        Console.WriteLine($"Данные прямые пересекаются в точке с координатами ({X0}; {Y0}).");
    }
}

Console.WriteLine("Введите коэффициент k1 для первой прямой y = k1 * x + b1 : ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1 для первой прямой y = k1 * x + b1 : ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2 для второй прямой y = k2 * x + b2 : ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2 для первой прямой y = k2 * x + b2 : ");
double b2 = Convert.ToDouble(Console.ReadLine());

CrossPoint(k1, k2, b1, b2);