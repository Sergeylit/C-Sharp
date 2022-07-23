//  #54

int[,] array = new int[7, 7];
int maxNumber = 0, minNumber = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
        Console.WriteLine();
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
Console.WriteLine("Первоначальный массив: ");
printArray(array);
Console.WriteLine();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             for(int k = j + 1; k < array.GetLength(1); k++)
           { 
                if(array[i, j] > array[i, k]) 
                {
                    minNumber = array[i, k];
                    maxNumber = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = maxNumber;   
                }
            }
        }
    }

        Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
printArray(array);