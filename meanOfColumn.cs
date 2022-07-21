int[,] array = new int[5, 5];
double[] mean = new double[5];
int sum = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
}
void printArray(int[,] arr)

{for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0} ", arr[i, j]);
            }
            Console.WriteLine();
    }
}
printArray(array);
Console.WriteLine();

for(int j = 0; j < array.GetLength(0); j++)
{
    for(int i = 0; i < array.GetLength(1); i++)
        {
            sum = sum + array[i, j];
        }
        mean[j] = (double)sum / (double)array.GetLength(0);
        sum = 0;
        Console.WriteLine();
}
for(int i = 0; i < mean.Length; i++)
    Console.Write("{0} ", mean[i]);