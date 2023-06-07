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

bool CheckMatrix(int[,] matr)
{
    if (matr.GetLength(0) == matr.GetLength(1)) return true;
    else return false;
}

void SwipRowsColumns(int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
            temp = matr[j, i];
            matr[j, i] = matr[i, j];
            matr[i, j] = temp;
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

if (CheckMatrix(array2D) == true)
{
    SwipRowsColumns(array2D);
    Console.WriteLine("Swipped matrix:");
    PrintMatrix(array2D);
}
else Console.WriteLine("Замена строк на столбцы невозможна");


