int[,] matrix1 = new int[5, 5];
int[,] matrix2 = new int[5, 5];
int[,] result = new int[5, 5];
void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine("Первая матрица: ");
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();

Console.WriteLine("Вторая матрица: ");
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();

for(int i = 0; i < matrix1.GetLength(0); i++)
{
    for(int j = 0; j < matrix1.GetLength(1); j++)
    {
        result[i, j] = matrix1[i, j] * matrix2[i, j];
    }
}

Console.WriteLine("Результат умножения матриц: ");
PrintArray(result);