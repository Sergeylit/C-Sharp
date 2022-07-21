int[,] array = new int[10, 10];
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