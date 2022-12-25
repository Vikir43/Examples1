using static System.Console;
Clear();

WriteLine("Введите число : ");
int a = Convert.ToInt32(ReadLine()); 

if (a< 6 )
{
    WriteLine("Не выходной день");
}
else
{
    WriteLine("Выходной день");
}
