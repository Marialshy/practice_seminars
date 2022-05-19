// 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("введите числа через ','");
string numbers = Convert.ToString(Console.ReadLine());
string[] arr = numbers.Split(','); // проверка на формат типа string? или есть ли запятая?
int countM = ConvertArray (arr);
Console.WriteLine($"{countM} чисел больше нуля");

int ConvertArray(string []array)
{
    int num = 0;
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        num = Int32.Parse (array[i]);
        if (num>0) count ++;
    }
    return count;
}


//int [] arr = new int[] {Convert.ToInt32(Console.ReadLine())};
/*
int n;
while (!int.TryParse (Console.ReadLine(), out n) || n <=0) // проверка n на тип данных (число типа int), и >0
    Console.WriteLine("Invalid input. Please enter positive integer number");
*/

