int[,] array = new int[5, 5];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
        Console.WriteLine();
}

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Введите через enter 2 числа, обозначающие позицию элемента массива");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(number1 < array.GetLength(0) && number2 < array.GetLength(1))
    Console.WriteLine(array[number1, number2]);
else Console.WriteLine("Такого элемента нет!");