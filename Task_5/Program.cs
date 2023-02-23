using System;
using static System.Console;

Clear();
int size = Promt("Введите размер массива: ");
int number = Promt("Введите число, с которого заполнять массив: ");
int[,] array = new int[size, size];
FillArray(array, number);
PrintArray(array);


int[,] FillArray(int[,] inArray, int number)
{
    int x = 0;
    int y = -1;
    int movRow = 0;
    int movCol = 1;
    while (number < inArray.GetLength(0) * inArray.GetLength(1))
    {
        if ((x + movRow >= 0 && x + movRow < number)
        && (y + movCol >= 0 && y + movCol < number)
        && inArray[x + movRow, y + movCol] == 0)
        {
            x += movRow;
            y += movCol;
            inArray[x, y] = number;
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
    return inArray;
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
int Promt(string massage)
{
    Write(massage);
    int value = int.Parse(ReadLine());
    return value;
}