Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = Distance (xA, yA, zA, xB, yB, zB);

Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
int kat1 = x1 - x2;
int kat2 = y1 - y2;
int kat3 = z1 - z2;
double hyp = Math.Sqrt(kat1 * kat1 + kat2 * kat2 + kat3 * kat3);
return hyp;
}