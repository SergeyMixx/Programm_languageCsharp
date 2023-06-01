Console.Write("Введите аргумент k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите аргумент b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите аргумент k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите аргумент b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double CrossPointCoordinateX(int arg1, int arg2, int arg3, int arg4)
{
    double x = (arg4 - arg2) / ((arg1 - arg3) * 1.0);
    return x;
}


double CrossPointCoordinateY(int arg1, int arg2)
{
    double Y = arg1 * CrossPointCoordinateX(k1, b1, k2, b2) + arg2;
    return Y;
}


double x = CrossPointCoordinateX(k1, b1, k2, b2);
double y = CrossPointCoordinateY(k1, b1);
Console.WriteLine($"Координаты точки пересечения -> ({x}; {y})");