using static System.Console;

WriteLine("Введите число : ");
int a = int.Parse(ReadLine()!);

if(a >99 )
    if (a>999)
       {
        WriteLine($"  {a=a/100%10}");
       }
    else
    {
    WriteLine($"  {a%10}");
    }
else
    {
    WriteLine("Третьей цифры нет");
    }
