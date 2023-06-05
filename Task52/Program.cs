Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();

    }
}

double[] GetColumnAver(int[,] matr, int size)
{
    double[] arr = new double[size];

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double aver = 0;
        int sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];

        }
        aver = 1.0 * sum / matr.GetLength(0);
        arr[j] = Math.Round(aver, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length) Console.Write($"{arr[i],4} ");
    }
}

int[,] array2D = CreateMatrixRndInt(m, n, 0, 10);
double[] res = GetColumnAver(array2D, n);
PrintMatrix(array2D);
Console.WriteLine("Средние значения по столбцам:");
PrintArray(res);

