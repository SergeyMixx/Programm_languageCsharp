﻿// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// int[] array0 = new int[] { 3, 6, 8, 8, 7 };
// var array2 = new int[8];

int[] array = new int[8];

FillArray(array);
PrintArray(array);


void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {        
        arr[i] = rnd.Next(2);
    }
    
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
Console.WriteLine();
}