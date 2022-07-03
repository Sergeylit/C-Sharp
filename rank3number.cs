Console.WriteLine("Ввведите трехзначное число");
char[] number = new char[3];
for(int i = 0; i < number.Length; i++)
number[i] = Convert.ToChar(Console.Read());

Console.WriteLine(number[1]);