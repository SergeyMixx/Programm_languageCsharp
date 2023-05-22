// Напишите программу, которая задаёт
// массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.

int[] array = new int[8];

FillArray(array);

Console.Write("[");
PrintArray(array);
Console.Write("]");

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {        
        arr[i] = rnd.Next(0,99);
    }
    
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
}