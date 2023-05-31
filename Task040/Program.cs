Console.WriteLine("Введите длину первой стороны: ");
int side1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину второй стороны: ");
int side2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину третьей стороны: ");
int side3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int s1, int s2, int s3)
{
    if (s1 >= s2 + s3) return false;
    if (s2 >= s1 + s3) return false;
    if (s3 >= s1 + s2) return false;
    return true;
}

void PrintResult(bool res, int s1, int s2, int s3)
{
    if (res == true) Console.WriteLine ($"Треугольник со сторонами {s1}, {s2}, {s3} может существовать");
    else Console.WriteLine ($"Треугольник со сторонами {s1}, {s2}, {s3} не может существовать");
}

bool result = Triangle(side1, side2, side3);
PrintResult(result, side1, side2, side3);
