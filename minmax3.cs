// #4

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if(a > b) max = a;
else max = b;
if(c > max) max = c;
Console.Write("Наибольшее число равно ");
Console.WriteLine(max);