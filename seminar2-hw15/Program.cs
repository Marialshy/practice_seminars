// по введенной цифре вывести ответ, выходной ли этот день недели
Console.WriteLine("введите день недели в числовом формате от 1 до 7");
int n = Convert.ToInt32(Console.ReadLine());
if (n>0 && n<=7)
{
    if (n==6 || n==7) Console.WriteLine("выходной");
    else Console.WriteLine("будний");
}
else Console.WriteLine("введите число от 1 до 7");