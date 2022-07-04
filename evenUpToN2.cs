Console.WriteLine("Введите число");
int MaxIndex = Convert.ToInt32(Console.ReadLine());
int[] EvenNumbers = new int[MaxIndex];
int index = 1;
EvenNumbers[0] = index;
for (; index < MaxIndex; index++)
    {
    if(index % 2 == 0)
        {
    int Even = index;
    Console.Write("{0} ", Even);
        }
    }