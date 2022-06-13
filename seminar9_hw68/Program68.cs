/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

при рекурсивном вызове или уменьшается значение m, или значение m сохраняется, но уменьшается значение n
m=0 -> n+1   
m>0, n=0 -> A(m-1,1)
m>0, n>0 -> A(m-1, A(m, n-1))
*/

Console.WriteLine("To start ");
int m = CheckInputInt("m");
int n = CheckInputInt("n");
Console.WriteLine(Akkerman(m,n));

int Akkerman(int m, int n)
{
    if (m==0) return n=n+1;
    else 
    {
        if (n==0) return Akkerman (m-1,1);
        else return Akkerman (m-1,Akkerman(m, n-1));
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
