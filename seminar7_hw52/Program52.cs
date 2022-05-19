// 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("for your new array: m strings, n coloumns,");
int m = CheckInputInt("m");
int n = CheckInputInt("n");
int[,] arr = new int[m, n];

FillArray(arr, -10, 10);
PrintArray(arr);
ArrayColoumnsAvSum(arr);

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

void ArrayColoumnsAvSum(int[,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += Convert.ToDouble(array[i, j]);
        }
        double sumAverage = Convert.ToDouble(sum / array.GetLength(0));
        Console.Write($"for coloumn #{j+1} average sum = {Math.Round(sumAverage,2)}");
        Console.WriteLine();
    }
}
