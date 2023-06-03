int[] TransformToBinary(int num)
{
    int temp = num;
    int size = 0;
    while (temp > 0)
    {
        temp = temp / 2;
        size ++;    
    }  
    
    int[] bin = new int[size];   
        
    for (int i = size-1; num > 0; i=i-1)
    {
        if (num % 2 == 0)  bin [i] = 0;
        else bin[i] = 1;
        num = num / 2;
    }
    return bin;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}");
    }
}


Console.Write("Задайте десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] res = TransformToBinary(number);

Console.Write("[");
PrintArray(res);
Console.WriteLine("]");