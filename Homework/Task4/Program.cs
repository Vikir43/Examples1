using static System.Console;

WriteLine("Введите три числа:  ");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int c = int.Parse(ReadLine()!);
int max = a;

if ( b > max ) {
    max = b;
}
if (c >max ) {
    max = c;
}

WriteLine($"Максимальнок число: {max} ");

  