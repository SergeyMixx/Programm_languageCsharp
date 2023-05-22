// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.


Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = NumSum (num);

Console.WriteLine($"Сумма цифр в числе {num} = {res}");

int NumSum(int a)
{
    int sum = 0;
    int temp = a;
    for (int i = 1; a != 0; i++)
    {
        temp = a % 10;
        sum = sum + temp;
        a = a / 10;
    }
    return sum;
}    