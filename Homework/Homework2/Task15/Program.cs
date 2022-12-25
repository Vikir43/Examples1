using static System.Console;
Clear();

WriteLine("Введите день недели от 1 до 7: ");
int a = Convert.ToInt32(ReadLine()); 

//if (a< 6 )
//{
  //  WriteLine("Не выходной день");
//}
//else
//{
  //  WriteLine("Выходной день");
//}
WriteLine(a < 6? "Не выходной день": a>7? "Нет такого дня недели": "Выходной день " );