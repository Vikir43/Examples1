// Принимает на вход число N и выдает количество цифр в числу
// 78-2  789 - 3
using static System.Console;
Clear();
Write("Введите число:  ");
int.TryParse(ReadLine(), out int n);

int number=NumCount(n);
WriteLine($"Количество цифр в числе = {number}");


int NumCount(int n)
{
    int result =0;
    if (n/10==0)
    return 1;
    else
    {
       while(n>0)
         {
            n=n/10;
            result+=1;
         }
    return result;
    }
}