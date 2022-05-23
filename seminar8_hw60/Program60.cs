// 60. Задать случайный трёхмерный массив из неповторяющихся двузначных чисел. При этом проверяется, что такого числа еще не было. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("for your array {x, y, z}");
int x = CheckInputInt("x");
int y = CheckInputInt("y");
int z = CheckInputInt("z");
int[,,] arr = new int[y, x, z];

if (x*y*z<90)
{
Fill3DArray(arr, 10, 100);
Print3dArray(arr);
}
else Console.WriteLine("please next time enter other value for {x, y, z}, there was not enough random numbers (x*y*z<90)");


void Fill3DArray(int[,,] array, int min, int max)
{
    Random rnd = new Random();
    int number = 0;
    bool check = false;

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (!check)
                {
                    number = rnd.Next(min, max);
                    check = CheckIfContains(arr, number);
                }
                array[i, j, k] = number;
                check = false;
            }

}

void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"[{i},{j},{k}] {array[i, j, k]} ");
        }
        Console.WriteLine();
    }
}

int CheckInputInt(string a)
{
    int n;
    Console.WriteLine($"please enter positive integer number for {a}");
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) // проверка n на тип данных (int)
        Console.WriteLine("Invalid input. Please enter positive integer number");
    return n;
}

bool CheckIfContains(int[,,] arr, int a)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
                if (a == arr[i, j, k])
                {
                    return false;
                }
    }
    return true;
}


