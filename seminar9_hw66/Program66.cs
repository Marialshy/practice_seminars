// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("To start ");
int m = CheckInputInt("m");
int n = CheckInputInt("n");
Console.WriteLine();
Console.WriteLine(SumNumbers(m, n));

int SumNumbers(int a, int b)
{

    if (b == a) return b;
    else return b += SumNumbers(a, b - 1);
}


int CheckInputInt(string a)
{
    int n;
    Console.WriteLine($"please enter positive integer number for {a}");
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) // проверка n на тип данных (int)
        Console.WriteLine("Invalid input. Please positive integer enter number");
    return n;
}