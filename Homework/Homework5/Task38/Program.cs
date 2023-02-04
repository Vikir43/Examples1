// Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами 
//и вычисления разницы между максимальным и минимальным элементов массива.
//[3,3 7,1 22,5 2,2 78,2] -> 76
using static System.Console;
Clear();

Write("Введите размер массива, минимального  и максимального  значения: ");
string[] inputVal = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] array = GetArray(int.Parse(inputVal[0]), Convert.ToDouble(inputVal[1]),Convert.ToDouble(inputVal[2]) );
PrintArray(array);
WriteLine();

var min = array[0];
var max = array[0];
for (int i = 0; i < array.Length; i++)
    
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

WriteLine($"Максимальное значение: {max:f2}  Минимальное значение: {min:f2}");
WriteLine($"Разница между максимальным и минимальным элементом массива: {max-min:f2}");

double[] GetArray(int size, double minValue, double maxValue)
{
   double[] array = new double [size];

    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().NextDouble()*(maxValue - minValue)+minValue;
    }
    return array;
  }
void PrintArray(double[] inArray)
{
   Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]:f2}  ");
    }
    Write($"{inArray[inArray.Length-1]:f2}]");
}
