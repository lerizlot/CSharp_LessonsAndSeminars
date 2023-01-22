int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input an {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
*/

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

int GetSumOfNegative(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];
    return sum;
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);

int result = GetSumOfNegative(newArray);
Console.WriteLine($"The sum of negative elements is: {result}");

/*
несколько типов методов по работе с массивами
1. генерирующие методы - создают массив
2. аналитические методы - используют массив как первоисточник для расчетов но не видоизменяют его
3. преобразующие методы - берут на вход массив но при этом возвращают преобразованную версию исходного массива
*/