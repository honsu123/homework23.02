Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1000)
{
    while(number > 999)
   {
    number /=10;
   }
    Console.WriteLine(number % 10);
}
else if (number < 99) 
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(number % 10);
