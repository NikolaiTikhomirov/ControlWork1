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


PrintArray(secondArray);


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