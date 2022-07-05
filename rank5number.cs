Console.WriteLine("Введите пятизначное число");
int[] number = new int[5];

for(int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToInt32(Console.Read());
    }

    if(number[0] == number[4] | number[1] == number[3])
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число не является палиндромом");
    