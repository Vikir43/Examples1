using static System.Console;

WriteLine("Введщите количество деталей за смену: ");
int detal = int.Parse(ReadLine()!);

WriteLine("Введите количество токарей младшего разряда:  ");
int count_tokar_1 = int.Parse(ReadLine()!);

WriteLine("Введите количество токарей старшего разряда:  ");
int count_tokar_4 = int.Parse(ReadLine()!);

int tokar_1 = 1;
int tokar_4 = 2 * (tokar_1+tokar_1);

int sum = tokar_1 * count_tokar_1 + tokar_4 * count_tokar_4;

if(detal % sum ==0)
{
    WriteLine("Это правда");
    WriteLine($"Каждый токарь младшего разряда сделал {detal/sum*tokar_1}");
    WriteLine($"Каждый токарь старшего разряда сделал {detal/sum*tokar_4}");
}
else {
    WriteLine("Они лгут");
}