// Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 > 11   82 > 10  9012 > 12
using static System.Console;
Clear();

Write("Введите число : ");
int num = int.Parse(ReadLine()!);

int sum = SumNum(num);
WriteLine($"Сумма цифр в числе = {sum}");


int SumNum(int num)
{
    int result=0;
    
    for (int i =1 ; i < num; i++)
    {
        result = result + num%10;
        num = num/10;
    }
    return result;
}