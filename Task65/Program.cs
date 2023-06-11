Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(m, n);

void NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
       
    }
    else if (num1 < num2)
    {
        Console.Write($" {num2} ");
        NaturalNumbers(num1, num2 - 1);        
    }
    else Console.Write($" {num1} ");
}