int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 999);
    }
    return arr;
}

int CountEvenNumbers(int[] arr)
{
    int countEven = 0;
    for (int i = 0; i < arr.Length; i++)
    {        
        if (arr[i] % 2 ==0) countEven += 1;
    }
    return countEven;
}

void PrintArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int[] array = CreateArrayRndInt(6);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int res = CountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в масиве -> {res}");