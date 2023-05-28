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

int[] ChangeNumber (int[] arr)
{    
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = arr[i] * (-1);    
    }
    return arr;
}

int[] array = CreateArrayRndInt(4, -9, 9);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int[] changeNumber = ChangeNumber(array);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");
