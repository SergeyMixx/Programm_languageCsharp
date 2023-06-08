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

void SortRowMaxMin(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1 - j; k++)
            {
                if (matr[i, k + 1] > matr[i, k])
                {
                    temp = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = temp;
                }
            }

        }
    }
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

int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
SortRowMaxMin(array2D);
Console.WriteLine("Sorted Matrix:");
PrintMatrix(array2D);