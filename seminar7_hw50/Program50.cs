// 50. По позиции элемента в двумерном массиве (ввод позиции с клавиатуры) возвращает значение этого элемента или же "такого элемента нет".
Console.WriteLine("To check the element in array, position (m, n), ");
int m = CheckInputInt("m");
int n = CheckInputInt("n");
int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

if (m <= arr.GetLength(0) && m <= arr.GetLength(1))
{
    int element = arr [m,n];
    Console.WriteLine($"Element[{m},{n}] = {element}");
}

else
    Console.WriteLine($"Element[{m},{n}] does not exist");

int CheckInputInt(string a)
{
    int n;
    Console.WriteLine($"please enter positive integer number or 0 for {a}");
    while (!int.TryParse(Console.ReadLine(), out n) || n < 0) // проверка n на тип данных (int)
        Console.WriteLine("Invalid input. Please positive integer enter number or 0");
    return n;
}