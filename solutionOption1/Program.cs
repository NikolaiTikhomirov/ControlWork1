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
