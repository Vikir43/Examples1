using static System.Console;
Clear();

Write("Точка А -> Введите координату x:  ");
int ax  = int.Parse(ReadLine()!);
Write("Точка А -> Введите координату y:  ");
int ay  = int.Parse(ReadLine()!);
Write("Точка B -> Введите координату x:  ");
int bx  = int.Parse(ReadLine()!);
Write("Точка B -> Введите координату y:  ");
int by  = int.Parse(ReadLine()!);

double d = Math.Sqrt(Math.Pow((bx-ax),2)+Math.Pow((by-ay),2));
WriteLine(d);

//int x = Math.Pow(ax-bx),2);
//int y = Math.Pow((by-ay), 2);
//int d = Math.Sqrt(x+y) 2;

