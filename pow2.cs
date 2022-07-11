Console.WriteLine("Введите число, возводимое в степень");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень числа");
double power = Convert.ToDouble(Console.ReadLine());
double result = Math.Pow(number, power);
Console.WriteLine("Результат равен " + result);