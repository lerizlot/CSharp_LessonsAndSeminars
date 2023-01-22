// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int[] GetReverse(int[] firstArray)
{
    for (int i = 0; i < firstArray.Length; i++) 
        firstArray[i] = firstArray[i] * -1;
    return firstArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Task1: ");

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] firstArray = CreateRandomArray(length, min, max);
ShowArray(firstArray);

int[] result1 = GetReverse(firstArray);
ShowArray(result1);
Console.WriteLine("-----------------");

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

bool GetSearch(int[] array, int x)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == x) return true;
    }
    return false;
}
Console.WriteLine("Task2: ");

Console.WriteLine("Input a number: ");
int x = Convert.ToInt32(Console.ReadLine());

int[] secondArray = CreateRandomArray(length, min, max);
ShowArray(secondArray);

Console.WriteLine(GetSearch(secondArray, x));
Console.WriteLine("-----------------");


// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b]

int GetQuantity(int[] array, int minNumb, int maxNumb)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= minNumb && array[i] <= maxNumb)
        {
            count += 1;
            // Console.WriteLine(array[i]);
        }
    return count;
}

Console.WriteLine("Task3: ");

Console.WriteLine("Input a dot a: ");
int minNumb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a dot b: ");
int maxNumb = Convert.ToInt32(Console.ReadLine());

int[] thirdArray = CreateRandomArray(length, min, max);
ShowArray(thirdArray);

int result3 = GetQuantity(thirdArray, minNumb, maxNumb);
Console.WriteLine($"The quantity of elements between {minNumb} and {maxNumb} is - {result3}");