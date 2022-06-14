// для исходного массива сформировать новый, где каждый элемент не длиннее 3х символов
Console.WriteLine("Please enter symbols splited by comma");
string someInput = Convert.ToString(Console.ReadLine());
int number = 3;

string [] newArray = FillArrayIfChar3(someInput);
PrintArray(newArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string [] FillArrayIfChar3(string text)
{
    int j = 0;
    string[] array = text.Split(',');
    string[] arrayNew = new string [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (Check3Char(array[i], number))
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
    return arrayNew;
}

bool Check3Char(string charA, int number)
{
    if (charA.Length <= number) return true;
    else return false;
}
