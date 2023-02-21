// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = FillArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
SortArray(array);
PrintArray(array);

int[,] FillArray(int rows, int columns, int a, int b)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(a, b);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void SortArray(int[,] inArray)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {            
            for (int k = 0; k < inArray.GetLength(1); k++)
            {
                {
                    if (inArray[i, j] > inArray[i, k])
                    {
                        int temp = inArray[i, k];
                        inArray[i, k] = inArray[i, j];
                        inArray[i, j] = temp;                        
                    }
                    else
                    {
                        
                    }
                }
            }
        }
    }
}