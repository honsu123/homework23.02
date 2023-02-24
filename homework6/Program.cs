Console.WriteLine("Напишите Число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}