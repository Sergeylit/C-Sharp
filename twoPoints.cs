Console.WriteLine("Поочередно введите 3 числа для обозначения первой точки");
double[] firstPoint = new double [3];
for(int i = 0; i < firstPoint.Length; i++)
    firstPoint[i] = Convert.ToDouble(Console.ReadLine());
    
Console.WriteLine("Поочередно введите 3 числа для обозначения второй точки");
double[] secondPoint = new double [3];
for(int i = 0; i < secondPoint.Length; i++)
    secondPoint[i] = Convert.ToDouble(Console.ReadLine());

    double distance = Math.Sqrt(Math.Pow((firstPoint[0] - secondPoint[0]), 2) + Math.Pow((firstPoint[1] - secondPoint[1]), 2) + Math.Pow((firstPoint[2] - secondPoint[2]), 2));
    Console.WriteLine("Расстояние между указанными точками равно {0}", distance);