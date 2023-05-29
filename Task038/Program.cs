double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double DiffNumbers(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    double diff = Math.Round(max - min, 1);
    return diff;
}

Console.Write("Задайте размер массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте минимальное вещественное число в массиве: ");
int arrMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте максимальное вещественное число в массиве: ");
int arrMax = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrayRndDouble(arrSize, arrMin, arrMax);
Console.Write("[");
PrintArrayDouble(array, ",");
Console.WriteLine("]");

double res = DiffNumbers(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива -> {res}");