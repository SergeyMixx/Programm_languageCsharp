Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)      // arr.GetLength(0) можно заменить на rows, в скобках номер измерения
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // arr.GetLength(1) можно заменить на columns
        {
            matrix[i, j] = i + j;
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
            Console.Write($"{matrix[i, j], 3} ");     
        }  
       Console.WriteLine();
       
    }
}

int[,] array2D = CreateMatrixRndInt(m, n, -100, 100);
PrintMatrix(array2D);