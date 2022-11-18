//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine ())); 

int x = 1;
do
  
{ 
    int square = x * x;
    x++;
    Console.Write(square + " ");

}
while (x <= number);

Console.WriteLine("");
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Math.Pow(i,2));
}

int count = 1;

while(count <= number)
{
    Console.WriteLine(count*count);
    count++;
}

