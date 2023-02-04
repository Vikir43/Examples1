// Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, 
//стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

int[] array = GetArray(4);
PrintArray(array);

int[] GetArray(int size)
{
    int[] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
       resultArray[i] = random.Next(-100, 100);
    }
    return  resultArray;
}

WriteLine();


int sum = 0;
    
 for (int i = 0; i < array.Length; i++)   
 {
   if (i % 2 == 1)
   { 
    sum += array[i];
   }
 } 
WriteLine($"Сумма = {sum}");

void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Write($"{array[i]},");
    }
    Write($"{array[array.Length-1]}]");
}