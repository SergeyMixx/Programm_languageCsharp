// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

Console.Write("Введите целое число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число В: ");
int numB = Convert.ToInt32(Console.ReadLine());

int degree = Deg (numA, numB);

Console.WriteLine($"Число {numA} в степени {numB} = {degree}");

int Deg(int a, int b)
{
    if (b == 0) return 1;
    else if (b == 1) return a;
    else
    {
        int res = a;
        for (int i = 2; i <= b; i++)
        {            
            res = res * a;
        }
        return res;
    }    
}