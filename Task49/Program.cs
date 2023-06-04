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

int[,] GetSquare(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i = i +2)     
    {
        for (int j = 0; j < matr.GetLength(1); j = j + 2) 
        {
           matr[i, j] = matr[i, j] * matr[i, j];
        }       
    }
    return matr;
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


int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix (array2D);
GetSquare (array2D);
Console.WriteLine();
PrintMatrix (array2D);