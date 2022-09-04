// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите через пробел размеры массива: ");
int [] parametrs = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=> int.Parse(x)).ToArray();
int [,] array = GetMatrix(parametrs[0], parametrs[1]);
PrintMatrix(array);
WriteLine();
int [,] array1 = ExchangeOfLines(array);
PrintMatrix(array1);




int [,]GetMatrix(int rows, int columns)
{
    int [,] arr = new int [rows, columns];
    for (int i = 0; i<rows; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            arr[i,j] = new Random ().Next(1,100);
        }
    }
    return arr;
}

void PrintMatrix(int[,]matrixForPrint)
{
    for (int i = 0; i<matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j<matrixForPrint.GetLength(1); j++)
        {
                Write($"{matrixForPrint[i,j]} ");
        }
        WriteLine();
    }
}

int [,] ExchangeOfLines(int[,] arr)
{
    int [,] newarr = arr;
           for (int j = 0; j<arr.GetLength(1); j++)
        {
            int variable = arr [0,j];
            newarr[0,j] = arr [arr.GetLength(0)-1, j];
            newarr [arr.GetLength(0)-1, j] = variable;
        }
    return newarr;
}