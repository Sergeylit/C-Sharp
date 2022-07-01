// #2
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max;
if(a > b) max = a;
else max = b;
Console.Write("Большее число равно ");
Console.WriteLine(max);