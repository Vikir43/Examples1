using static System.Console;
Clear();

Write("Введите день недели: ");
int i = int.Parse(ReadLine()!);

switch(i)
{
    case 1:
    {
        WriteLine("Рабочий день");
        break;
    }
    case 2:
    {
        WriteLine("Рабочий день");
        break;
    }
    case 3:
    {
        WriteLine("Рабочий день");
        break;
    }
    case 4:
    {
        WriteLine("Рабочий день");    
        break;
    }
    case 5:
    {
        WriteLine("Рабочий день");    
        break;
    }
    case 6:
    {
        WriteLine("Выходной день");    
        break;
    }
    case 7:
    {
        WriteLine("Выходной день");    
        break;
    }
    default:
    {
        WriteLine("Ошибка");
        break;
    }
}


//if(i<1 || i >4)
//{
   // WriteLine("Ошибка");
    //return;
//}
//if (i == 1)
//{
   // WriteLine("x>0 y>0");
//}
//if (i == 2)
//{
   //WriteLine("x<0 y>0");
//}
//if (i == 3)
//{
   // WriteLine("x<0 y<0");
//}
//if (i == 4)
//{
//WriteLine("x>0 y<0");
//}