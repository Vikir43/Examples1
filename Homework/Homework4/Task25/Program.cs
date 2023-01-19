// Принимает на вход два числа А и В и возводит число А в натуральную степень В с использованием цикла
// 3,5 > 243   2,4 > 16
using static System.Console;
Clear();

Write("Введите число A: ");
int numberA = int.Parse(ReadLine()!);
Write("Введите число B: ");
int numberB = int.Parse(ReadLine()!);

int exponent=Exponent(numberA, numberB);
WriteLine($"Натуральная степень числа А возведенная в степень В = {exponent}");


int Exponent(int numberA, int numberB)
{
    int result=1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}