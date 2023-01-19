﻿// Принимает на вход число А и выдает сумму чисел от 1 до А
using static System.Console;
Clear();
Write("Input number1:  ");
int number1 = int.Parse(ReadLine()!);

int sum1=GetSum(number1);
WriteLine($"Sum number 1..A = {sum1}");

Write("Input number2:  ");
int number2 = int.Parse(ReadLine()!);

int sum2=GetSum(number2);
WriteLine($"Sum number 1..A = {sum2}");



int GetSum(int A)
{
    int result=0;
    while(A>0)
    {
        result += A;
        A--;
    }
    return result;
}