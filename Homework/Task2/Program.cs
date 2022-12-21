using static System.Console;

WriteLine("Введите число 1: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введитечисло 2: ");
int b = int.Parse(ReadLine()!);

if (a > b)
{
    WriteLine($"Максимальное число {a} ");
}
else 
{
    WriteLine($"Максимальноне число {b} ");
}


