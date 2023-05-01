Console.WriteLine("Введите трёхзначное число число");
int number = Convert.ToInt32(Console.ReadLine()); 

int midDigit = ModifyNumber(number);
Console.WriteLine($"Вторая цифра числа -> {midDigit}");

int ModifyNumber (int num) 
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}