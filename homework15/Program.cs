Console.WriteLine("Напишите цифру");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0 && number<8)
    if  (number>5)
        Console.WriteLine("Это выходной");
    else
        Console.WriteLine("Это не выходной");
else
    Console.WriteLine("день не подходит");