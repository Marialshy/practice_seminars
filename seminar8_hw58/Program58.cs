//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("for your first matrix (m strings, n coloumns)");
int m = CheckInputInt("m");
int n = CheckInputInt("n");
int[,] arr = new int[m, n];
Console.WriteLine("for your second matrix the count of strings has to be the same as the first matrix's coloumns; and q coloumns,");
int q = CheckInputInt("q");
int[,] arr2 = new int[n, q];
int[,] arrM = new int[m, q];

FillArray(arr, -5, 5);
PrintArray(arr);
Console.WriteLine();
FillArray(arr2, -5, 5);
PrintArray(arr2);
Console.WriteLine();
MatrixMultiplic(arrM, arr, arr2);
PrintArray(arrM);

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

void MatrixMultiplic(int[,] array, int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        int i1 = i;
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int j2 = j;
            {
                int sumOfStringXColoumn = 0;
                for (int j1 = 0; j1 < array1.GetLength(1); j1++)
                {
                    int String1XColoumn2 = array1[i1, j1] * array2[j1, j2];
                    //Console.WriteLine($"[{i1},{j1}]*[{j1},{j2}]={String1XColoumn2}");
                    sumOfStringXColoumn += String1XColoumn2;
                }
                //Console.WriteLine(sumOfStringXColoumn);
                array[i, j] = sumOfStringXColoumn;
            }
        }
    }
}
