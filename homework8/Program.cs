Console.WriteLine("Напишите число");
int number = Convert.ToInt32(Console.ReadLine());
int step = 2;
if (number>1);
{
    while(step <= number)
    {
        Console.WriteLine(step + " ");
        step = step + 2;
    }
}