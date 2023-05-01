Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine()); 

int ost = number1 % number2;

if (Divisible (number1, number2) == true)
{
Console.WriteLine("кратно");
}
else
{
Console.WriteLine($"не кратно, остаток {ost}");
}

bool Divisible (int num1, int num2) 
{
    if (num1 % num2 == 0) return true;
    else return false;
}

