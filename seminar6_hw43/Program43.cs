// 43. Точка пересечения двух прямых: y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine($"For two lines y1 = k1*x + b1, y2 = k2*x + b2");
double k1 = CheckInputInt("k1");
double b1 = CheckInputInt("b1");
double k2 = CheckInputInt("k2");
double b2 = CheckInputInt("b2");

if (k1!=k2){
    double x = (b2 - b1) / (k1 - k2);//k1*x+b1=k2*x+b2
    double y = k1 * x + b1;
    Console.WriteLine($"lines crossed at point M ({x}, {y})");
}
else Console.WriteLine("these two lines are parallel");

double CheckInputInt(string a)
{
    double n;
    Console.WriteLine($"Please enter number for {a}");
    while (!double.TryParse(Console.ReadLine(), out n)) // проверка n на тип данных (число типа double)
        Console.WriteLine("Invalid input. Please enter number");
    return n;
}

