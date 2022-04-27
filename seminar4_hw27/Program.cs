// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int n;
Console.WriteLine("Please enter positive integer number");
while (!int.TryParse (Console.ReadLine(), out n) || n <=0){
    Console.WriteLine("Invalid input. Please enter positive integer number");
}
int sumN (int a) 
{
   int result = 0;
   while(a>=1){
       result = result+a%10;
       a=a/10;
    }
    return result;
}
Console.Write("-> "+sumN(n));
