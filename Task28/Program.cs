// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Product(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product = product * i;
    }   
    return(product);
    
}

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine ());
int prod = Product(A);
Console.WriteLine("Произведение чисел " + prod);