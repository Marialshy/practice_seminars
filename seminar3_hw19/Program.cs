// проверить, является ли введенное с клаиватуры 5-значное число палиндромом
Console.WriteLine("enter 5-digit number");
int n = Convert.ToInt32(Console.ReadLine());
if (n<=99999 && n>9999) Console.WriteLine("let's check if your number is palindrome...");// проверка на 5-зн
else Console.WriteLine("your number isn't 5-digit. plese try again");

int symb1 = n/10000;
int symb5 = n%10;
int symb2 = (n%10000-n%1000)/1000;
int symb4 = (n%100 - n%10)/10;

void palindrome()
{
     if (symb1==symb5 && symb2==symb4) Console.WriteLine("yes!");
     else Console.WriteLine("no");
}
palindrome();