//Math.Sqrt() нахождение квадратного корня
//Math.Pow(a, 2) возведение числа а в степень 2
//Math.Round(a, 2) округление числа a до 2х знаков после запятой

// Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//AB = √(xb - xa)2 + (yb - ya)2 

Console.WriteLine("Введите координату X точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X  точки B: ");
int xb = Convert.ToInt32(Console.ReadLin0e());
Console.WriteLine("Введите координату Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
Console.WriteLine($"Расстояние между двумя точками A({xa},{ya}) и B({xb},{yb}) равно {Math.Round(ab, 2)}");


