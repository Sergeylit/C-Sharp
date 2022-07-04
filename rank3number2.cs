Console.WriteLine("Введите трёхзначное число");

int number = Convert.ToInt32(Console.ReadLine());
if(number / 100 < 1 || number / 1000 >= 1)
    {
        Console.WriteLine("Число не трёхзначное");
    }
    else
    {
        int thirdNumber = (number % 10);
        Console.WriteLine(thirdNumber);
    }
