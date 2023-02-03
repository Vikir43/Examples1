﻿// Задать массив из 123 случайных чисел. Найти количество эл массива, значения которых лежат в отрезке от 10 до 99.
using static System.Console;
Clear();

int[] array = GetArray(123, 0, 100);
PrintArray(array);

WriteLine();

WriteLine($"Количество элементов массива в заданнои интервале равно: {ArrayCount(array)}");

int ArrayCount(int[] InArray)
{
    int result = 0;
    foreach(int i in InArray)
    {
        if(10 <= i && i <= 99) result++;
    }
    return result;
}

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray=new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue +1);
    }
    return resultArray;
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