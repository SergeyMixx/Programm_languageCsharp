
Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayInt(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1}е чисело: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int PositiveNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum++;
    }
    return sum;
}

int[] array = CreateArrayInt(m);
int res = PositiveNumbers(array);
Console.WriteLine($"Количество положительных чисел -> {res}");
