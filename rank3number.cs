Console.WriteLine("Ввведите три числа");
int[] number = new int[3];
for(int i = 0; i < number.Length; i++)
number[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number[1]);