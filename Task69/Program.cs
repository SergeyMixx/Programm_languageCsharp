Console.Write("Введите целое число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int res = AgradeB(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} равно {res}");

int AgradeB(int a, int b)
{
    if (b == 0) return 1;     
    return a * AgradeB(a, b-1);
}
 
