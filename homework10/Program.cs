// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Напишите трёхзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number = 0;
if (number1>99 && number1<1000)
{
    number = number1 / 10;
    number = number % 10;
    Console.WriteLine(number);
}    
else
    Console.WriteLine("Число не подходит");
