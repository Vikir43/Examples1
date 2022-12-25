using static System.Console;
Clear();

Write("Введите пятизначное число: ");
int i = int.Parse(ReadLine()!);

if((i/10000 == i%10)&&((i/1000)%10 == (i%100)/10))
{
    WriteLine("Да, является полиндромом");
}
else
{
    WriteLine("Нет, не является полиндромом");
}
