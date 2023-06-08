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
    int indMinRow = 0;
    int[] arr = new int[matr.GetLength(1)];
    int minRowSum = 0;
    for (int k = 0; k < matr.GetLength(1); k++)
    {
        minRowSum = minRowSum + matr[0, k];
    }

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            rowSum = rowSum + matr[i, j];
        }

        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            indMinRow = i;
        }
    }
    Console.WriteLine($"Номер строки с минимальной суммой элементов: {indMinRow+1}");

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        arr[j] = matr[indMinRow, j];
    }
    return arr;
    //Console.WriteLine($"Номер строки с минимальной суммой элементов: {indMinRow}");
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
Console.WriteLine("Строка с минимальной суммой элементов:");
PrintArray(res);