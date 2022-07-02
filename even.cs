// #6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.Write("Число {0} четное", number);
}
else
{
    Console.Write("Число {0} нечетное", number);
}