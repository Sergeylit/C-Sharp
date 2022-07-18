double  b1 = 9, b2 = -5, 
        k1 = -2, k2 = 4;

double x = (b1 - b2) / (k2 - k1);
double y = x * k1 + b1;
Console.WriteLine("({0}; {1})", Math.Round(k1 * x + b1, 3), Math.Round(k2 * x + b2, 3));
