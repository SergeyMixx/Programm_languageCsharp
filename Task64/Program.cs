Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

bool CheckIfNumberNatural (int n)
{
if (n > 0) return true;
else return false; 
}

if (CheckIfNumberNatural(number) == true)
{
    NaturalNumbers(number);
}    
else Console.WriteLine("Число не натуральное");

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num -1);    
}
