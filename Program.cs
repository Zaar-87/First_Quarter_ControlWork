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

//input and output
string[] inputArray = GetArray();
int count = WordsCount(inputArray);
string[] finalArray = ResultArray(inputArray, count);
Console.WriteLine($"[{String.Join(", ", inputArray)}] -> [{String.Join(", ", finalArray)}]");

//functions

//function that filling the array with data from the user
string[] GetArray()
{
    Console.WriteLine("How many words would be in the array?");
    int stringLength = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Please, enter the words: ");
    string[] inputArray = new string[stringLength];
    for (int i = 0; i < stringLength; i++)
    {
        inputArray[i] = Console.ReadLine()!;
    }
    return inputArray;
}

//definition words with three character or less
int WordsCount(string[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

//forming final array with words with three character or less
string[] ResultArray(string[] inputArray, int newLenght)
{
    string[] finalArray = new string[newLenght];
    int k = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            finalArray[k] = inputArray[i];
            k++;
        }
    }
    return finalArray;
}