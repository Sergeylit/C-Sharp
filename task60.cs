int[,,] numbers = new int[3, 3, 3];
int[] checkForRepeat = new int[27];

Console.WriteLine("Элементы массива с индексами: ");
Console.WriteLine();
for (int i = 0, l = 0; i < numbers.GetLength(0) && l < checkForRepeat.Length; i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int k = 0; k < numbers.GetLength(2); k++, l++)
        {
            equalsTo:
            numbers[i, j, k] = new Random().Next(9, 100);
            foreach (int m in checkForRepeat)
            {

                if (numbers[i, j, k] == m)
                {
                    Console.WriteLine("tick");
                    goto equalsTo;
                }
            }
            checkForRepeat[l] = numbers[i, j, k];
            Console.Write(numbers[i, j, k] + "({0}, {1}, {2}) ", i, j, k);
        }
        Console.WriteLine();
    }
}