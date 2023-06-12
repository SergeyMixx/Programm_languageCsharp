Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumberRec = SumNumbers(number);
Console.WriteLine($"Сумма цифр в {number} равна {sumNumberRec}");

int SumNumbers(int num)
{
    if (num == 0) return 0;     
    return num % 10 + SumNumbers(num / 10);

}
 