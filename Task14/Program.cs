﻿using static System.Console;

WriteLine("Введите число a :");
int a = int.Parse(ReadLine()!);
WriteLine("Введите число b : ");
int b = int.Parse(ReadLine()!);

WriteLine( a*a==b? "b является квадратом a" : b*b == a?  "a является квадратом b" : "Нет, не является");

