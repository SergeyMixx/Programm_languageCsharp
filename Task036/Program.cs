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

int CountNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

Console.Write("Задайте размер массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте минимальное значение в массиве: ");
int arrMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте максимальное значение в массиве: ");
int arrMax = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(arrSize, arrMin, arrMax);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int res = CountNumbers(array);
Console.WriteLine($"Сумма элементов на нечётных позициях -> {res}");