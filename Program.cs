/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.

Примеры:
{"hello", "2", "world", ":-)"} // -> {"2", ":-)"}
{"1234", "1567", "-2", "computer science"} // -> {"-2"}
{"Russia", "Denmark", "Kazan"} // -> {}
*/

string[] initArray = GetArray();
int count = WordsCount(initArray);
string[] finalArray = ResultArray(initArray, count);
Console.WriteLine($"[{String.Join(", ", initArray)}] -> [{String.Join(", ", finalArray)}]");

string[] GetArray()
{
    Console.WriteLine("How many words would be in the array?");
    int stringLength = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Please, enter the words: ");
    string[] formedArray = new string[stringLength];
    for (int i = 0; i < stringLength; i++)
    {
        formedArray[i] = Console.ReadLine()!;
    }
    return formedArray;
}

int WordsCount(string[] formedArray)
{
    int count = 0;
    for (int i = 0; i < formedArray.Length; i++)
    {
        if (formedArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] ResultArray(string[] formedArray, int newLenght)
{
    string[] resultArray = new string[newLenght];
    int k = 0;
    for (int i = 0; i < formedArray.Length; i++)
    {
        if (formedArray[i].Length <= 3)
        {
            resultArray[k] = formedArray[i];
            k++;
        }
    }
    return resultArray;
}