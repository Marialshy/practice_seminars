//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("for your new array: m strings, n coloumns,");
int m = CheckInputInt("m");
int n = CheckInputIntAdd("n",m);

int[,] arr = new int[m, n];

FillArray(arr, -10, 10);
PrintArray(arr);
ArrayRowsAvSum(arr);

void FillArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int CheckInputInt(string a)
{
    int n;
    Console.WriteLine($"please enter positive integer number for {a}");
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) // проверка n на тип данных (int)
        Console.WriteLine("Invalid input. Please positive integer enter number");
    return n;
}

int CheckInputIntAdd(string a, int b)
{
    int n;
    Console.WriteLine($"please enter positive integer number for {a}");
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n==b) // проверка n на тип данных (int) и не равно ли ранее введенному числу
        Console.WriteLine($"Invalid input. Please enter positive integer number *use the value for n, not the same as {m}");
    return n;
}

void ArrayRowsAvSum(int[,] array)
{
    int [] tmpArr = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumR = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumR += array[i, j];
        }
        tmpArr [i] = sumR;
        //onsole.WriteLine($"for tmpArr {i}, element = {sumR}");
    }
    int minR = MinArrayIndex(tmpArr);
    Console.WriteLine($"the minimal sum is the result for string {minR+1}");
}

int MinArrayIndex (int[] array)
{
    int Min = 0;
    for (int i = 1; i<array.Length; i++)
        if (array[i]<array[Min]) Min=i;
    return Min;
}