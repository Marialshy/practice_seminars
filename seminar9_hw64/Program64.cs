// 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("To start ");
int m = CheckInputInt("m");
int n = CheckInputInt("n");
Console.WriteLine();
NaturalNum(m,n);

void NaturalNum (int a, int b)
{
    if(b==a) Console.Write(b+" ");
    else
    {
        NaturalNum(a, b-1);
        Console.Write(b+" ");
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
