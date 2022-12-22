using static System.Console;

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);

int max = a;

if (a > b)
{
    WriteLine("Максимальное число {a} ");
}
else 
{
    WriteLine("Максимальноне число (b) ");
}
