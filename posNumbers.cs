Console.Write("Введите количество цифр: ");
int numbersIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите несколько чисел, после ввода числа нажимайте enter");
int[] numbers = new int [numbersIndex];
for(int i = 0; i < numbers.Length; i++) numbers[i] = Convert.ToInt32(Console.ReadLine());
    int count = 0;
for(int i = 0; i < numbers.Length; i++)
if(numbers[i] > 0)
    count++;
Console.WriteLine("Чисел больше нуля: " + count);