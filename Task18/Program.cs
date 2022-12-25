using static System.Console;
Clear();

WriteLine("Введите координаты x:  ");
int x  = int.Parse(ReadLine()!);
WriteLine("Введите координаты y:  ");
int y  = int.Parse(ReadLine()!);

if(x==0 || y==0)
{
    WriteLine("Ошибка");
    return;
}
if (x>0&&y>0)
{
   WriteLine("Первая четверть");
}
if (x<0&&y>0)
{
   WriteLine("Вторая четверть");
}
if (x<0&&y<0)
{
    WriteLine("Третья четверть");
}
if (x>0&&y<0)
{
    WriteLine("Четвертая четверть");
}
//switch(x y)
//{
    //case 1:
    //{
        //WriteLine($"Первая четверть {x>0} {y>0}");
        //break;
    //}
    //case 2:
    //{
       // WriteLine($"Вторая четверть {x>0} {y>0}");
       // break;
    //}
    //case 3:
    //{
        //WriteLine($"Третья четверть {x>0} {y>0}");
        //break;
    //}
    //case 4:
    //{
       // WriteLine($"Четвертая четверть {x>0} {y>0}");
        //break;
    //}
    //default:
    //{
        //WriteLine("Ошибка");
       // break;
    //}
//}
