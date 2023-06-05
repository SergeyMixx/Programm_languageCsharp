Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

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