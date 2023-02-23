// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;

Clear();
int size = Promt("Введите размер массива (число от 2 до 9): ");
if (size < 10 && size > 1)
{
    int[,] resArray = FillArray(size);
    string[,] strArray = GetStringArray(resArray);
    PrintArray(strArray);
}
else
{
    WriteLine("Ошибка ввода!");
    return;
}
string[,] GetStringArray(int[,] inArray)
{
    string[,] resArray = new string[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            resArray[i, j] = (inArray[i, j] < 10) ? "0" + Convert.ToString(inArray[i, j]) : Convert.ToString(inArray[i, j]);
        }
    }
    return resArray;
}
int[,] FillArray(int size)
{
    int[,] resArray = new int[size, size];
    int number = 1;
    int x = 0;
    int y = -1;
    int movRow = 0;
    int movCol = 1;
    while (number <= resArray.GetLength(0) * resArray.GetLength(1))
    {
        if ((x + movRow >= 0 && x + movRow < size)
        && (y + movCol >= 0 && y + movCol < size)
        && resArray[x + movRow, y + movCol] == 0)
        {
            x += movRow;
            y += movCol;
            resArray[x, y] = number;
            number++;
        }
        else
        {
            if (movCol == 1)
            {
                movCol = 0;
                movRow = 1;
            }
            else if (movRow == 1)
            {
                movRow = 0;
                movCol = -1;
            }
            else if (movCol == -1)
            {
                movCol = 0;
                movRow = -1;
            }
            else if (movRow == -1)
            {
                movRow = 0;
                movCol = 1;
            }
        }
    }
    return resArray;
}
void PrintArray(string[,] inArray)
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
int Promt(string massage)
{
    Write(massage);
    int value = int.Parse(ReadLine());
    return value;
}