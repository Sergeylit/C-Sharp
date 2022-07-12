int[] numbers = new int[20];
int count = 0;
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100, 999);
    if(numbers[i] % 2 == 0) count++;
    Console.WriteLine("Число номер {0} равно {1}", i+1, numbers[i]);
}
Console.WriteLine("Количество четных чисел в массиве - " + count);