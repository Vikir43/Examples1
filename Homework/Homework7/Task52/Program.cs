// Напишите программу реализующую методы, формирования двумерного массива и 
//массива средних арифметических значений каждого столбца.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[]parameters= ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(array);

WriteLine();


double[] newArray = new double[array.GetLength(1)];
for (int j = 0; j < array.GetLength(1); j++) 
{ 
    newArray [j] = 0;
    for (int i = 0; i < array.GetLength(0); i++) 
       
        {
            newArray[j] += array[i, j];
        }
    newArray[j] = newArray[j] /array.GetLength(1);
    Write($"[{newArray[j]:f2}]");
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