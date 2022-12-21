using static System.Console;

WriteLine("Введите число : ");
int a = int.Parse(ReadLine()!);
int n = 2;

if(n>1)
{
    while (n <= a)  
   {
    Write( n  );
    n = n + 2;
   } 
}   