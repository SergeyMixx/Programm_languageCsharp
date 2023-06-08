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

bool CheckMatrixesFit(int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(1) == matr2.GetLength(0)) return true;
    else return false;
}

int[,] MatrixesMultiply(int[,] matr1, int[,] matr2)
{
    int[,] resMatrix = new int[matr2.GetLength(1), matr1.GetLength(0)];

    for (int i = 0; i < matr2.GetLength(1); i++)
    {
        for (int j = 0; j < matr1.GetLength(0); j++)
        {
            resMatrix[i, j] = matr1[i, j] * matr2[i, j] + matr1[i, j + 1] * matr2[i + 1, j];
        }
    }
    return resMatrix;
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

int[,] matrix1 = CreateMatrixRndInt(3, 4, 0, 10);
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);

int[,] matrix2 = CreateMatrixRndInt(4, 3, 0, 10);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);

if (CheckMatrixesFit(matrix1, matrix2) == false)
{
    Console.WriteLine("Умножать матрицы нельзя");
}
else
{
    int[,] resultMatrix = MatrixesMultiply(matrix1, matrix2);
    Console.WriteLine("Результат перемножения:");
    PrintMatrix(resultMatrix);
}