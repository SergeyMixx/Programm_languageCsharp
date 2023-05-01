int number = new Random().Next(100, 1000); 
Console.WriteLine($"Случайное трехзначное чило -> {number}");

int modDigit = ModifyNumber(number);
Console.WriteLine($"Исправленное число -> {modDigit}");

int ModifyNumber (int num) 
{
    int firstDigit = num / 100 * 10;
    int secondDigit = num % 10;
    int result = firstDigit + secondDigit;
    return result;
}