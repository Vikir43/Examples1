using static System.Console;

int number = new Random().Next(100, 999);
WriteLine(number);

//int a1 = number/100;
//int a2 = number%10;
int a1 = number/100;
int a2 = number%10;
WriteLine($"{a1} {a2}");



