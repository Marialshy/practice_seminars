//Задача 36: Задайте одномерный массив, заполненный случайными числами (длина с треминала). Найдите сумму элементов на нечётных позициях. 
Console.WriteLine("введите кол-во элементов массива");
int arrLong = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[arrLong];
FillArrayA(arr);
PrintArray (arr);

void FillArrayA(int[] array) 
{
    for (int i =0; i<array.Length; i++)
        array[i]=new Random().Next(1000);
}

void PrintArray(int[] array)
{
    for (int i =0; i<array.Length; i++)
        Console.Write(array[i]+"; ");
}

int OddSumArray(int[] array)
{
    int sum = 0;
    for (int i =1; i<array.Length; i+=2)
        sum = sum + array[i];
    return sum;
}
Console.WriteLine("сумма нечётных элементов массива = "+OddSumArray(arr));
