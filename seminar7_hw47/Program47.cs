//47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("for your new array: m strings, n coloumns,");
int m = CheckInputInt("m");
int n = CheckInputInt("n");
double[,] arr = new double[m, n];

FillArray(arr);
PrintArray(arr);

void FillArray(double[,] array)
{
    Random rnd = new Random(); //коммент внизу
    int maxValue = 100;
    int minValue = -100;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j],2)} "); // Math.Round - округление (переменная, кол-во знаков)
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


/*для вызова метода NextDouble  должна быть ссылка на объект, те нужно инициировать переменную к которой этот метод применяется:
Random rnd = new Random();
double a = rnd.NextDouble() - в этом случае диапазон 0,0 - 1,0
для диапазона случайных вещественных чисел между двумя произвольными значениями нужно умножать случайное число на ненулевое значение
Random rnd = new Random();
int maxValue = 100;
int minValue = -100;
int a = rnd.NextDouble() * (maxValue - minValue) + minValue;

для целых чисел в диапазоне 10 - 99:
int a = new Random().Next(10,100);
*/