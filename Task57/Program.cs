// Array.Sort(arr) можно использовать для сортировки одномерного массива

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

int[] MatrixToArray(int[,] matrix)
{
    int size = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array = new int[size];
    int ind = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[ind] = matrix[i, j];
            ind++;
        }
    }
    return array;
}

void CheckArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] == array [j]) count++;
        }
        Console.WriteLine($"{array[i]}  встречается {count} раз");
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
int[] arrayRes = MatrixToArray(array2D);
PrintMatrix(array2D);
CheckArray(arrayRes);
