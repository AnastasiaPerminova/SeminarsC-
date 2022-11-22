// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Console.WriteLine("Введите  число: ");
// int number = Convert.ToInt32(Console.ReadLine ());

// // int changedNumber = number;
// // int count = 0;
// // while (changedNumber > 0)
// // {
// //     changedNumber /= 10;
// //     count++;
// // }

// // Console.WriteLine($"В числе {number} - {count} цифр");
// string number1 = number.ToString();
// Console.WriteLine($"В числе {number} - {number1.Length} цифр");

Console.WriteLine("Введите  число: ");
string A = Console.ReadLine ();
if (int.TryParse( A, out int num))
    Console.WriteLine("Количество цифр в числе:" + A.Length);
else 
    Console.WriteLine("В строке не только цифры, напишите число!");