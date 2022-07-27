int[,] numbers = new int[5, 5];
int[] sum = new int[5];
int sumMin = 0, stringMin = 0;
for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 10);
    }
}

void printArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0} ", arr[i, j]);
            }
            Console.WriteLine();
    }
}
Console.WriteLine("Массив: ");
printArray(numbers);
Console.WriteLine();

for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
            {
                sumMin += numbers[i, j];
            }
            sum[i] = sumMin;
            sumMin = 0;
            Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Суммы ");
    for(int i = 0; i < sum.Length; i++)
    Console.WriteLine(sum[i]);
    Console.WriteLine();

    sumMin = sum[0];
    for(int i = 0; i < sum.Length; i++)
        if(sum[i] < sumMin)       
            stringMin = i;
        

    Console.WriteLine();
    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (stringMin + 1));