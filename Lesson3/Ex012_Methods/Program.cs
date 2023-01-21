// Вид 1
// ничего не принимает, ничего не возвращает
void Method1()
{
    Console.WriteLine("Что-то ...");
}
Method1();

// Вид 2
// принимает аргумент, ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);

// Вид 3
// ничего не принимает, что-то возвращает
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4
// что-то принимает, что-то возвращает
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    { 
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);

// Цикл for
string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;

    }
    return result;
}
string result = Method41(10, "qwerty");
Console.WriteLine(result);


// Цикл в цикле: таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

// ==== Работа с текстом
/* Дан текст. В тексте нужно все пробелы заменить черточками,  маленькие буквы "к" заменить большими буквами "К", а большие "С" заменить маленькими "с".
*/

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
                + "ежели бы вас послали вместо нашего милого Винценгероде,"
                + "вы бы взяли приступом согласие прусского короля. "
                + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);

// Упорядочить массив: алгоритм сортировки методом выбора
// 6 8 3 2 1 4 5 7

// 1. найти позицию минимального элемента в неотсортированнной части массива;
// 2. произвести обмен этого значения со значением первой неотсортированной позиции
// 3. повторять пока есть не отсортированные элементы

int[] arr = { 6, 8, 3, 2, 1, 4, 5, 7, 7 };

// метод который выводит данный массив на экран
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// метод упорядочивающий массив
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);
