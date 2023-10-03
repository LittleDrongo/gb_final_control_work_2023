/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", "Denmark", "Kazan"] → []
*/
Console.Clear();
string[] inputeArray = CreateManualArrayStr();
Console.WriteLine("Исходный массив до алгоритма");
PrintArrayStr(inputeArray);
string[] sortedArray = SortByStringLenght(inputeArray, 3);
Console.WriteLine("Исходный массив");
PrintArrayStr(inputeArray);
Console.WriteLine("Копированный массив массив");
PrintArrayStr(sortedArray);

void PrintArrayStr(string[] array)
{
    Console.Write("[");
    Console.Write(string.Join(", ", array));
    Console.WriteLine("]");
}

string[] CreateManualArrayStr()
{
    Console.Write("Введите кол-во строк для первоначального массива: ");
    int count = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Заполните массив {count} раз");
    string[] array = new string[count];
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{i + 1} из {count}: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] SortByStringLenght(string[] array, int maxLength)
{
    int strs = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string currentString = array[i];
        int currentStringLength = currentString.Length;
        if (currentStringLength <= maxLength)
        {
            strs++;
        }
    }

    string[] sortArray = new string[strs];

    int j = 0;

    for (int index = 0; index < array.Length; index++)
    {
        string currentString = array[index];
        int currentStringLength = currentString.Length;

        if (currentStringLength <= maxLength)
        {
            sortArray[j] = currentString;
            j++;
        }
    }
    return sortArray;
}