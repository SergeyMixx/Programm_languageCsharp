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

void PrintMatrix(int[,] matrix) //разделитель убираем для удобства
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3} ");     // 3 символа для выравнивания
        }  
       Console.WriteLine();
       
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);
