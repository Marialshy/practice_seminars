// из двух введенных числе выбирает большее
Console.WriteLine("введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine("max = "+ number1 +" ");
}
else
{
    Console.WriteLine("max = "+ number2 +" ");
}