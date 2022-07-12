int[] numbers = new int[20];
int sum = 0;
for(int i = 1; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-1000, 1000);
    sum = sum + numbers[i];
    Console.WriteLine("Элемент номер {0} равен {1}", i, numbers[i]);
    i++;
}
Console.WriteLine("Сумма элементов массива с нечетным индексом равна " + sum);