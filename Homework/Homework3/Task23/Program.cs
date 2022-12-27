using static System.Console;
Clear();

int i=1;
Write("Введите число для вывода кубов чисел от 1 до N:  ");
int.TryParse(ReadLine(), out int n);


while (i <n+1)  
{
    WriteLine($"{i} = {Math.Pow(i, 3)}");
    i++;
}