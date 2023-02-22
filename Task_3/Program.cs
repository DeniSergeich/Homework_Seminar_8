// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
 
using System;
using static System.Console;
 
Clear();
Write("Введите количество строк первой матрицы: ");
int rowsFirstArray = int.Parse(ReadLine());
Write("Введите количество столбцов первой матрицы: ");
int columnsFirstArray = int.Parse(ReadLine());
int rowsSecondArray = columnsFirstArray;
WriteLine($"Количество строк второй матрицы: {rowsSecondArray}. Защита от дурака =)");
Write($"Введите количество столбцов второй матрицы: ");
int columnsSecondArray = int.Parse(ReadLine());
WriteLine();
int[,] array1 = FillArray(rowsFirstArray, columnsFirstArray);
int[,] array2 = FillArray(rowsSecondArray, columnsSecondArray);
int[,] resultArray = ResultArray(array1, array2);
WriteLine("Первая матрица:");
PrintArray(array1);
WriteLine();
WriteLine("Вторая матрица:");
PrintArray(array2);
WriteLine();
WriteLine("Результат умножения:");
PrintArray(resultArray);
 
int[,] FillArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
 
int[,] ResultArray(int[,] array1, int[,] array2)
{    
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultArray;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}