// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using static System.Console;
Clear();

Write("Введите размер прямоугольной матрицы: ");
string[]parameters= ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(array);

int minSum = Int32.MaxValue;
int rowLine = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        rowLine = i+1;
    }
}
WriteLine($"Строка с наименьшей суммой: {rowLine}");



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