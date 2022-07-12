int[] numbers = new int[20];
int min = 100, max = 0;
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(1, 100);
    if(numbers[i] < min && numbers[i] != min) min = numbers[i];
    else max = numbers[i];
    Console.WriteLine("Элемент номер {0} равен {1}", i, numbers[i]);
}
Console.WriteLine();
Console.WriteLine("Минимальное {0}, максимальное {1}", min, max);
int difference = max - min;
Console.Write("Разница между наименьшим и наибольшим значениями массива равна " + difference);