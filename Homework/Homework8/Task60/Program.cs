// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
using static System.Console;
Clear();
Write("Введите размер трехмерной матрицы: ");
string[]parameters= ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,,] matrix = GetMatrixArray(new int[] {int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), },10,99);
PrintMatrixArray(matrix);
WriteLine();


int[,,] GetMatrixArray(int [] size, int max, int min)
{
    Random rnd=new Random();
    int[,,] result=new int[size[0], size[1], size[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(10, 99);
                if (FindElement(result, element)) continue;
                result[i, j,k] = element;
                k++;
            }                   
        }
    }
     return result;
}
bool FindElement (int [,,] matrix, int num)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == num) return true;
            }
        }
    }
    return false;
}
void PrintMatrixArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
       for (int j = 0; j < inArray.GetLength(1); j++) 
       {
        for (int k = 0; k < inArray.GetLength(2); k++)
        {                   
             Write($"{inArray[i,j, k],3} ({i},{j},{k}) "); 
        } 
       WriteLine(); 
       }
    }
}