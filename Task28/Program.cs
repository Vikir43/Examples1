// Выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке [0,1,0,10,1,0]
using static System.Console;
Clear();

int [] arr = GetArray();

GetArray ();
PrintArray(arr);

void FullArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
}

int[] GetArray ()
{
    int [] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(2);
    }
    return array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        WriteLine($"{array[i]}");
    }
}
