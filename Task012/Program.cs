Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine()); 

if (Divisible (number1, number2) == true)
{
Console.WriteLine("кратно");
}
else
{
Console.WriteLine($"не кратно, остаток {Ost (number1, number2)}");
}

bool Divisible (int num1, int num2) 
{
    if (num1 % num2 == 0) return true;
    else return false;
}

int Ost (int num1, int num2) 
{
return num1 % num2;
}
