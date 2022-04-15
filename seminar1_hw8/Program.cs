// все четные числа от 1 до N, где N введенное
Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count<=N)
{
Console.Write(count);
Console.Write(", ");
count +=2;
}
