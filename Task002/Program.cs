Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine()); 
int max = number1;
int min = number2;
if (number1 < number2) {
    max = number2; 
    min = number1;
}
Console.WriteLine($"Большее число = {max}");
Console.WriteLine($"Меньшее число = {min}");