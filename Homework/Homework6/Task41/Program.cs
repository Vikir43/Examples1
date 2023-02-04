//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
using static System.Console;

Write("Введите числа через запятую: ");
int [] arr = Array.ConvertAll(ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
   if(arr[i]>0)
   {
    count++;
   } 
}
WriteLine($"Количество элементов в массиве > 0 = {count}");