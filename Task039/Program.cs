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

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

void ReverseArray(int[] arr)    //создаем свой метод, хотя есть встроенный Array.Reverse(array); 
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i]; 
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp; 
    }
}

int[] array = CreateArrayRndInt(5, 1, 9);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

ReverseArray(array);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

// Array.Reverse(array);  встроенная функция

// Console.Write("[");
// PrintArray(array);
// Console.WriteLine("]");