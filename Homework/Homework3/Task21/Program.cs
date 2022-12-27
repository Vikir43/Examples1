using static System.Console;
Clear();

WriteLine($"Точка А -> Введите координаты x, y, z ");
int ax  = int.Parse(ReadLine()!);
int ay  = int.Parse(ReadLine()!);
int az  = int.Parse(ReadLine()!);
WriteLine("Точка B -> Введите координаты x  y  z  ");
int bx  = int.Parse(ReadLine()!);
int by  = int.Parse(ReadLine()!);
int bz  = int.Parse(ReadLine()!);

double d = Math.Sqrt(Math.Pow((bx-ax),2)+Math.Pow((by-ay),2)+Math.Pow((bz-az),2));
WriteLine($"{d:f2}");