int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[] SearchMinSumRow(int[,] matr)
{
    int indMaxRow = 0;
    int[] arr = new int[matr.GetLength(1)];
    int maxRow = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
        int rowSum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            rowSum = rowSum + matr[i, j];
        }
        if (rowSum > maxRow)
        {
            maxRow = rowSum;
            indMaxRow = i;
        }
    }
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        arr[j] = matr[indMaxRow, j];
    }
    return arr;
    //Console.WriteLine($"Номер строки с максимальной суммой элементов: {indMaxRow}")
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],3} ");        
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
int[] res = SearchMinSumRow(array2D);
Console.WriteLine("Строка с максимальной суммой элементов:");
PrintArray(res);