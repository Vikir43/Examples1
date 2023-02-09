// Рекурсия. Напишите программу, которая реализует рекурсивный метод вывода всех натуральных чисел в промежутке от N  до 1.
//N = 5 => 5,4,3,2,1
//N=8 => 8,7,6,5,4,3,2,1
using static System.Console;
Clear();
PrintNumbers(6);

WriteLine();
string result = GetNumbers(6);
WriteLine(result);


void PrintNumbers(int num)
{
    if(num == 1) Write( $"{num}");
    else
    {
        
        Write($"{num},");
        PrintNumbers(num-1);
    }
}
string GetNumbers(int num)
{
    if (num == 1) return num.ToString();
    else return $"{num},{GetNumbers(num-1)}"; 
}
