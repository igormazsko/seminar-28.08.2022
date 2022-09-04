/*Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/
using static System.Console;
using System.Linq;
Clear();
Write("Введите количество строк в матрице m= ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов в матрице n= ");
int n = int.Parse(ReadLine());
int [,]matrix= new int [m, n];
FillMassRandomNambers(matrix);
PrintMatrixArray(matrix);
WriteLine();
if (matrix.GetLength(0)!=matrix.GetLength(1))
{
    WriteLine("Поменять местами строи и столбцы невозможно");
    return;
}
else
{
    PrintMatrixArray(RowsPerColumn(matrix));
}

// Метод заполнения двухмерного массива случайными числами
void FillMassRandomNambers (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1, 11);
        }
    }
}

// Метод печати двухмерного массива заполненного вещественными значениями
void PrintMatrixArray(int [,] inArray)
{
    for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray [i,j]} ");
        }
        WriteLine();
    }
}
// Метод замены строк на столбцы
int [,] RowsPerColumn (int [,] array)
{
    int [,] newArray = new int [array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i,j]=array[j,i];
        }
    }
    return newArray;
}