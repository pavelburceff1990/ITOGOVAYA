int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CreateArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        stringArray[i] = Console.ReadLine();
    }
}
void PrintAray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]} ");
    }
}
int SearchSize3Char(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
void CreateNewArray(string[] oldArray, string[] newArray)
{
    for (int i = 0, j = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3)
        {
            newArray[j] = oldArray[i];
            j++;
        }
    }
}
Console.Write($"Введите количество слов/фраз, которе хотите ввести: ");
int size = InputNumber();
string[] stringArray = new string[size];
Console.WriteLine($"Введите желаемые слова/фразы: ");
CreateArray(stringArray);
PrintAray(stringArray);
Console.WriteLine();
int newSize = SearchSize3Char(stringArray);
string[] newStringArray = new string[newSize];
if (newSize > 0)
{
    CreateNewArray(stringArray, newStringArray);
    Console.WriteLine("Все элементы с размером 3 или меньше:");
    PrintAray(newStringArray);
}
else Console.WriteLine("Нет элементов с размером 3 символа или меньше.");
