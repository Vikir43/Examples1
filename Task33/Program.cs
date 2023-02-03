// Задать массив. Написать программу, которая определяет, присутствует ли заданное число в массиве.
// 4 маааси 6,7,19,345,3 - нет
// 3 массив 6,7,19,345,3 - да
using static System.Console;
Clear();

Write("Введите число: ");
int.TryParse(ReadLine(), out int number);

int[] array = {6, 7, 19, 345,3};

//ool result = ArrayLookUp(array, number);
WriteLine(ArrayLookUp(array, number)?"да" : "нет");

bool ArrayLookUp(int[] inArray, int num)
{
    foreach (int i in inArray)
    {
        if (num == i) return true;
    }
    return false;
}