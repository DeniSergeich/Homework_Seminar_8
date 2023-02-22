// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;
using static System.Console;

Clear();
int cell = Promt("Введите количество таблиц: ");
int row = Promt("Введите количество строк в таблицах: ");
int col = Promt("Введите количество столбцов в таблицах: ");
if (cell * row * col > 90)
{
    WriteLine("Создание массива с уникальными элементами невозможно! Не хватит уникальных элементов.");
}
else
{
    int[,,] array = FillArray(cell, row, col);
    PrintArray(array);
}

int[,,] FillArray(int cell, int row, int col)
{    
    int[] arrayNumbers = new int[90];
    for (int l = 0; l < arrayNumbers.Length; l++)
    {
        arrayNumbers[l] = l + 10;
    }
    int[,,] resArray = new int[cell, row, col];
    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            for (int k = 0; k < resArray.GetLength(2); k++)
            {
                int t = new Random().Next(0, 90);
                if (arrayNumbers[t] != 0)
                {
                    resArray[i, j, k] = arrayNumbers[t];
                    arrayNumbers[t] = 0;
                }
                else
                {
                    while (arrayNumbers[t] == 0)
                    {
                        t = new Random().Next(0, 90);
                    }
                    resArray[i, j, k] = arrayNumbers[t];
                    arrayNumbers[t] = 0;
                }
            }
        }
    }
    return resArray;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
    }
}

int Promt(string massage)
{
    Write(massage);
    int value = int.Parse(ReadLine());
    return value;
}