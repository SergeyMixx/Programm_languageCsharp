int[] CreateArrayRndInt(int size, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, max + 1);
    }
    return arr;
}

void PrintResult(int[] arr, bool result, string sep)
{
    Console.Write("массив [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
    if (result == true) Console.Write("] -> да");
    else Console.Write("] -> нет");
}

bool CheckNumber(int[] arr, int num)
{    
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] == num) return true;        
    }    
    return false;   
}

Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(5, 10);
bool res = CheckNumber(array, number);
PrintResult(array, res, ",");



