Console.WriteLine("Напишите три числа");
int first_number = Convert.ToInt32(Console.ReadLine());
int second_number = Convert.ToInt32(Console.ReadLine());
int third_number = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (first_number>second_number) max = first_number;
else max = second_number;
if (third_number>max) max = third_number;
Console.WriteLine(max);
