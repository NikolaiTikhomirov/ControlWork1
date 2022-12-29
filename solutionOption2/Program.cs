// Вариант решения задачи №2


Console.Write("Какой длинны массив вам потребуется? ");
bool isParsedArrayLength = int.TryParse(Console.ReadLine(), out int arrayLength);
if(!isParsedArrayLength)
{
    Console.WriteLine("Длина массива определяется цифрами! Попробуйте еще раз. :)");
    return;
}
string[] firstArray = new string[arrayLength];
Console.WriteLine("Заполните массив разными строками.");
FillArray (firstArray);
Console.Write("Укажите максимальную длину строк, которые Вы хотите увидеть в новом массиве? ");
int stringMax = int.Parse(Console.ReadLine());
string[] secondArray = new string[arrayLength];
CopyArrayFilteringStringLength(firstArray, secondArray, stringMax);
PrintArray(secondArray);


void CopyArrayFilteringStringLength(string[] fullArray, string[] filteredArray, int filter)
{
    for (int i = 0; i < fullArray.Length; i++)
    {
        if (fullArray[i].Length <= filter) filteredArray[i] = fullArray[i];
    }
}
void FillArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}
void PrintArray(string[] col)
{
    Console.WriteLine($"[{string.Join(", ", col)}]");
}