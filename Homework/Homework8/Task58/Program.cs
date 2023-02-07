// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
///Результирующая матрица будет:
//18 20
//15 18
using static System.Console;
Clear();

Write("Введите размер матрицы A: ");
string[]parameters= ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Write("Введите размер матрицы B: ");
string[]parameters1= ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] matrixA = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(matrixA);
WriteLine();

int[,] matrixB = GetMatrixArray(int.Parse(parameters1[0]), int.Parse(parameters1[1]));
PrintMatrixArray(matrixB);
WriteLine();

int[,] matrixC = NewMatrixMultoplic(matrixA, matrixB);
WriteLine();

PrintMatrixArray(matrixC);

int[,] NewMatrixMultoplic(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
       for (int j = 0; j < matrixB.GetLength(1); j++) 
            {

                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] = matrixC[i, j] + (matrixA[i, k]*matrixB[k, j]);
                }
            }
    }
    return matrixC;
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