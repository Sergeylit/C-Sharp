Console.WriteLine("Введите число");
double number = Convert.ToDouble(Console.ReadLine());
for(double i = 0; i < number; i++)
{
    double pow = Math.Pow(i, 3);
    Console.WriteLine(pow);
}