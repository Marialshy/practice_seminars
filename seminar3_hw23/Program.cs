// вывести кубы чисел от 1 до n, полученного с клавиатуры
int getCube (int a)
{
    int ax3=a*a*a;
    return ax3;
}

Console.WriteLine("enter number");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count<=n) 
{
    int nx3 = getCube (count);
    Console.Write(""+ nx3 +"; ");
    count ++;
}