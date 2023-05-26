int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int[] GetSumPostiveNegative(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sumPositive = sumPositive + arr[i];
        else
            sumNegative = sumNegative + arr[i];
    }
    return new int[]{sumPositive, sumNegative};
}

int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int[] sumPositiveNegative = GetSumPostiveNegative(array);
Console.WriteLine($"сумма положительных элементов равна {sumPositiveNegative[0]}");
Console.WriteLine($"сумма отрицательных элементов равна {sumPositiveNegative[1]}");
