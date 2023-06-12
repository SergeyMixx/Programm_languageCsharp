Console.Write("Введите неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

bool CheckIfNumberPositive(int m, int n)
{
    if (n >= 0 && m >= 0) return true;
    else return false;
}

if (CheckIfNumberPositive(m, n) == true)
{
    int res = Ack(m, n);
    Console.WriteLine($"{res}");
}
else Console.WriteLine("Число отрицательное");

int Ack(int num1, int num2)
{
    if (num1 == 0) return (num2 + 1);
    else if (num2 == 0) return Ack(num1 - 1, 1);
    else return Ack(num1 - 1, Ack(num1, num2 - 1));
}