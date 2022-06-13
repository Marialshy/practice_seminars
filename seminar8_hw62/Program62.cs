// 62. заполнить спирально массив 4*4
Console.WriteLine("for your new array (a rows, b coloumns)");
int aRow = CheckInputInt("a");
int aColoumn = CheckInputInt("b");

int[,] arr = new int[aRow, aColoumn];
int i = 0;
int j = 0;
int istart = 0;
int iend = 0;
int jstart = 0;
int jend = 0;
FillArraySpin(arr);
PrintArray(arr);

void FillArraySpin(int[,] array)
{
    int a = 1;

    while (array[i,j]<array.GetLength(0)*array.GetLength(1))
    {
        array[i, j] = a;
        a++;

        if (i == istart && j < array.GetLength(1) - jend - 1) j++;
        else if (j == array.GetLength(1) - jend - 1 && i < array.GetLength(0) - iend - 1) i++;
        else if (i == array.GetLength(0) - iend - 1 && j > jstart) j--;
        else if (j == jstart && i > istart+1) i--;
        else
        {
            istart++;
            iend++;
            jstart++;
            jend++;
            a--;
        }
    }
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

