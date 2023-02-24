Console.WriteLine("Напишите первое число");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int second_number = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (first_number>second_number) max = first_number;
else max = second_number;
Console.WriteLine(max);