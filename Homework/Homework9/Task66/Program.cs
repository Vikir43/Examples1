// Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.
// m =1, n=15 ->A(m,n) = 120
// m =4, n=8 ->A(m,n) = 30
using static System.Console;
Clear();

WriteLine(Sum (1, 15));

int Sum (int m, int n)
{
    
    if (n == m) return m;
    else
    {      
         return Sum(m, n-1) + n;
    }
    
    
   
}
