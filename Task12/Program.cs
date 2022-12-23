using static System.Console;

 Write("Введите первое число: ");
 int a = int.Parse(ReadLine()!);
 Write("Введите второе число: ");
 int b = int.Parse(ReadLine()!);

 //WriteLine("{a>b}? ">": $"{a<b}? "<":);
 if (a>b)
 {
    WriteLine(">");
 }
 else
 {
    WriteLine ("<");
 }
