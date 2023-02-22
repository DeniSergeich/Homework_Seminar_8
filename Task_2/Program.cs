// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 
// Например, задан массив:
 
// 1 4 7 2
 
// 5 9 2 3
 
// 8 4 2 4
 
// 5 2 6 7
 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 
using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = FillArray(rows, columns);
PrintArray(array);
int[] sumRowArray = SumRowArray(array);
WriteLine();
GetMinSumRowArray(sumRowArray);
 
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
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
int[] SumRowArray(int[,] inArray)
{    
    int[] sumRowArray = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sumRow += inArray[i, j];
        }
        sumRowArray[i] = sumRow;
    }
    return sumRowArray;
}
void GetMinSumRowArray(int[] inArray)
{
    int min = inArray[0];
    int index = 0;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (min > inArray[i])
        {
            min = inArray[i];
            index = i;
        }        
    }
    WriteLine($"Строка №:{index + 1} имеет наименьшую сумму элементов.");
}