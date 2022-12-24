using static System.Console;

int number = new Random().Next(100, 999);
WriteLine(number);

int a1 = number/10%10;
WriteLine($" {a1}");