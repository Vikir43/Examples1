// Напишите программу реализующую методы формирования массива, заполненного случайными положительными трёхзначными числами,
// и подсчета количества чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
using static System.Console;
Clear();

int[] array = GetArray(6);
PrintArray(array);

int[] GetArray(int size)
{
    int[] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
       resultArray[i] = random.Next(100, 999);
    }
    return  resultArray;
}

WriteLine();

WriteLine($"Количество четных чисел в массиве: {ArraySum(array)}");

int ArraySum(int[] InArray)
{
    int result = 0;
    foreach(int i in InArray)
    {
        if(i%2 ==0) result++;
    }
    return result;
}

void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Write($"{array[i]},");
    }
    Write($"{array[array.Length-1]}]");
}