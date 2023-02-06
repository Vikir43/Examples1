// Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, 
//и возвращающий значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1;7 -> такого элемента в массиве нет
//1;1 -> 9
using static System.Console;
Clear();

Write("Введите размер матрицы (количество строк и столбцов) и позицию элемента (x y) (через пробел): ");
int[] parameters= Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetMatrixArray((parameters[0]), (parameters[1]));

PrintMatrixArray(array);
WriteLine();
SerchMatrixRosition (array, parameters[2], parameters[3]);

void SerchMatrixRosition (int[,] array, int x, int y)
{
    WriteLine(x <= array.GetLength(0) && y <= array.GetLength(1) ? $"На данной позиции элемент: {array[x, y]}" 
    : "Такого элемента в массиве нет" );
}
int[,] GetMatrixArray(int rows, int colums)
{
    Random rnd=new Random();
    int[,] resultArray=new int[rows,colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i,j]=rnd.Next(1, 10);
        }
    }
     return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
       for (int j = 0; j < inArray.GetLength(1); j++) 
       {
        Write($"{inArray[i,j],3} "); 
       } 
       WriteLine(); 
    }
}
