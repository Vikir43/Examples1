// Принимает на вход число N и выдает произведенние чисел от 1 до N
// 4-24  5 - 120
using static System.Console;
Clear();
Write("Введите число: ");
int.TryParse(ReadLine(), out int n);

int multi=MultiNum(n);
WriteLine($"Произведение чисел от 1 до N = {multi}");


int MultiNum(int n)
{
    int result=1;
    while(n>0)
    {
        result = result * n;
        n--;
    }
    return result;
}