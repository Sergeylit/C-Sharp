int[] newArray = new int[8];
for(int i = 0; i < newArray.Length; i++)
{
    newArray[i] = new Random().Next(1, 1000);
    Console.WriteLine("Элемент массива {0} - {1}", i+1, newArray[i]);
}