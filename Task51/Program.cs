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

int DiagSum(int[,] matr)
{
    int sum = 0;
    int size = 0;
    if (matr.GetLength(0) < matr.GetLength(1)) size = matr.GetLength(0);
    else size = matr.GetLength(1);
    for (int i = 0; i < size; i++)
    {
    sum = sum + matr[i, i];
    }
    // for (int i = 0; i < matr.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matr.GetLength(1); j++)
    //     {
    //         if (i == j) sum = sum + matr[i, j];
    //     }
    // }
    return sum;
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

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);
int res = DiagSum(array2D);
Console.WriteLine(res);
