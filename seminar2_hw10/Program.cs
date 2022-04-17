// для введенного трехзначного числа показывает вторую цифру
Console.WriteLine("введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1000 && n > 99)
{
    int result = (n%100 - n%10)/10;
    Console.WriteLine("вторая цифра вашего числа: "+ result +"");
}
else Console.WriteLine("число должно быть трехзначным");


