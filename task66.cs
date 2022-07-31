int M = new Random().Next(0, 51);
int N = new Random().Next(51, 100);
int sum = 0;
Console.WriteLine("start {0}, finish {1}", M, N);
Console.WriteLine();
for(int i = M + 1; i <= N - 1; i++)
    sum += i;
Console.WriteLine("Сумма элементов от M до N равна " + sum);