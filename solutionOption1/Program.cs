// Вариант решения задачи №1

Console.Write("Какой длинны массив вам потребуется? ");
bool isParsedFirstArrayLength = int.TryParse(Console.ReadLine(), out int firstArrayLength);
if(!isParsedFirstArrayLength)
{
    Console.WriteLine("Длина массива определяется цифрами! Попробуйте еще раз. :)");
    return;
}
string[] firstArray = new string[firstArrayLength];
Console.WriteLine("Заполните массив разными строками.");
for (int i = 0; i < firstArrayLength; i++)
{
    firstArray[i] = Console.ReadLine();
}
int secondArrayLength = 0;
for (int i = 0; i < firstArrayLength; i++)
{
    if (firstArray[i].Length <= 3 && firstArray[i].Length > 0) secondArrayLength = secondArrayLength + 1;
}
string[] secondArray = new string[secondArrayLength];
int j = 0;
for (int i = 0; i < firstArrayLength; i++)
{
    if (firstArray[i].Length <= 3 && firstArray[i].Length > 0)
    {
        secondArray[j] = firstArray[i]; j++;
    }
}
