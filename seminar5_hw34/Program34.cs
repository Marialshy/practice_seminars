// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами (длина с терминала). Вывести кол-во чётных чисел в массиве. 

Console.WriteLine("введите кол-во элементов массива");
int arrLong = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[arrLong];
FillArray(arr,100,999);
PrintArray (arr);

void FillArray(int[] array, int minValue, int maxValue) 
{
    Random random = new Random();
    for (int i =0; i<array.Length; i++)
        array[i]=random.Next(minValue,maxValue+1);
}

void PrintArray(int[] array)
{
    for (int i =0; i<array.Length; i++)
        Console.Write(array[i]+"; ");
}

int MultOf2(int[] array)
{
    int count = 0;
    for (int i =0; i<array.Length; i++)
        if (array[i]%2==0) count ++;
    return count;        
}
Console.WriteLine("кол-во четных чисел в массиве -> "+MultOf2(arr));
