// Написать программу замена элементов массива: полож элементы на соответ отриц и наоборот
// -4,-8,8,2  на 4,8,-8,-2
using static System.Console;
Clear();


int[] array = {-4, -8, 8, 2};
PrintArray(array);
Console.WriteLine();

ReverseArray(array);
PrintArray(array);

void ReverseArray(int[] inArray)
{
for (int i = 0; i <= inArray.Length-1; i++)
    {
        inArray[i] *= -1;
    }
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}