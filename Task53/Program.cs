﻿int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

void ChangeFirstLastRow(int[,] matr)
{
    int lastPosition = matr.GetLength(0) - 1;
    int firstPosition = 0;
    int temp = 0;
    for (int j = 0; j < matr.GetLength(1); j++) 
    {
        temp = matr[firstPosition,j];
        matr[firstPosition,j] = matr[lastPosition,j];
        matr[lastPosition,j] = temp;
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
ChangeFirstLastRow(array2D);
Console.WriteLine("Array with changed rows:");
PrintMatrix(array2D);

