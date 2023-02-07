// Задать двумерный массив. Написать программу, которая упорядочит по убываю элементы.
// 1 4 7 2   ; 7 4 3 1
// 5 9 2 3  ;  9 5 3 2
using static System.Console;

Write("Введите размер матрицы через пробел: ");
string[]parameters= ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(array);

WriteLine();
SortedMatrixArray(array);
PrintMatrixArray(array);

void SortedMatrixArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
    {
       for (int j = 0; j < inArray.GetLength(1); j++) 
       {
            for (int k = 0; k < inArray.GetLength(1)-1; k++)
            {
                if (inArray[i, k] < inArray[i, k + 1])
                {                    
                int temp = inArray[i, k +1];
                inArray[i, k +1] = inArray[i, k];
                inArray[i, k] = temp;
                }
            }    
       }
    }   
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
