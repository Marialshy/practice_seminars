// для введенного числа вывести третью цифру или "третьей цифры нет"
Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n<0) n=-n;
else n=n;
if (n > 99)
{
    while(n>1000)
    {
        n = n/10;
    }
    int result = n %10;
    Console.WriteLine("третья цифра вашего числа: "+ result +"");
}
else Console.WriteLine("третьей цифры нет");

