Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

bool CheckIfNumberNatural(int m, int n)
{
    if (n > 0 && m > 0) return true;
    else return false;
}

if (CheckIfNumberNatural(m, n) == true)
{
    int res = NaturalNumbers(m, n);
    Console.WriteLine($"Сумма чисел -> {res}");
}
else Console.WriteLine("Число не натуральное");

int NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {        
        return num1 + NaturalNumbers(num1 - 1, num2);       
    }
    
    else if (num1 < num2)
    {
        return num2 + NaturalNumbers(num1, num2 - 1);        
    }
    else return num1;
}    