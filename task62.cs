int[,] spiral = new int[10, 10];
    for (int count = 1, i, j, position = 0; position < spiral.GetLength(0) / 2; position++)
    {
        for (j = position; j < spiral.GetLength(0) - position; j++)
            spiral[position, j] = count++;
        for (i = position + 1, j -= 1; i < spiral.GetLength(1) - position; i++)
            spiral[i, j] = count++;
        for (i = j, j -= 1; j > position; j--)
            spiral[i, j] = count++;
        for (; i > position; i--)
            spiral[i, j] = count++;
    }

for (int i = 0; i < spiral.GetLength(0); i++)
{
    for (int j = 0; j < spiral.GetLength(1); j++)
    {
        Console.Write(spiral[i, j] + " ");
    }
    Console.WriteLine();
}