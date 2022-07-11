Console.WriteLine("Введите целое число");
int sum = 0;
int number = Convert.ToInt32(Console.ReadLine());
while(number != 0)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine("Сумма цифр числа равна " + sum);