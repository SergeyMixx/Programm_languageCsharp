Console.WriteLine("Введите строку элемнета: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец элемента: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)      // arr.GetLength(0) можно заменить на rows, в скобках номер измерения
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // arr.GetLength(1) можно заменить на columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void GetElement(int[,] matr, int m, int n)
{
    if (m > matr.GetLength(0) || n > matr.GetLength(1))
    {
        Console.WriteLine("Элемента нет в массиве");
    }
    else Console.WriteLine($"Элемент -> {matr[m - 1, n - 1]}");
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");     // 3 символа для выравнивания
        }
        Console.WriteLine();

    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 20);
PrintMatrix(array2D);

GetElement(array2D, m1, n1);