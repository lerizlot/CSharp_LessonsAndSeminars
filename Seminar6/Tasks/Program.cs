// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

bool CheckExistance(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.Write("Input number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool answer = CheckExistance(a, b, c);
Console.WriteLine($"The answer is: {answer}");

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b

// каждый новый элемент является суммой двух предыдущих

int[] Fibonacci(int size, int a, int b)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < size; i++)
        array[i] = array[i - 2] + array[i - 1];
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of fibonacci sequince: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first element: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second element: ");
int b1 = Convert.ToInt32(Console.ReadLine());

int[] newArray = Fibonacci(size, a1, b1);
ShowArray(newArray);

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return array;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] originalArray = CreateRandomArray(length, min, max);
ShowArray(originalArray);
int[] arrayCopy = CopyArray(originalArray);
ShowArray(arrayCopy);
