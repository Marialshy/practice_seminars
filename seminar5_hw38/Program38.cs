// Задача 38: Задайте массив вещественных чисел (длина с терминала). Найдите разницу между макс и мин элементами.
Console.WriteLine("введите кол-во элементов массива");
int arrLong = Convert.ToInt32(Console.ReadLine());
double [] arr = new double[arrLong];
FillArrayA(arr);
PrintArray (arr);
// min&max find, diff
double diff = MaxArray(arr)-MinArray(arr);
Console.WriteLine("разница между минимальным и максимальным элементами = "+diff);

void FillArrayA(double[] array) 
{
    for (int i =0; i<array.Length; i++)
        array[i]=new Random().Next(100);
}

void PrintArray(double[] array)
{
    for (int i =0; i<array.Length; i++)
        Console.Write(array[i]+"; ");
}

double MaxArray (double[] array)
{
    double Max = array[0];
    for (int i =1; i<array.Length; i++)
        if (array[i]>Max) Max=array[i];
    return Max;
}
double MinArray (double[] array)
{
    double Min = array[0];
    for (int i =1; i<array.Length; i++)
        if (array[i]<Min) Min=array[i];
    return Min;
}
