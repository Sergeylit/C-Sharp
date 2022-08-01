static int Function(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n != 0 && m == 0)
        return Function(n - 1, 1);
    else
        return Function(n - 1, Function(n, m - 1));
}

Console.WriteLine(Function(3, 2));