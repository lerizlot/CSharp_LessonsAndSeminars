// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0) &&
       row2 >= 0 && row2 < array.GetLength(0) &&
       row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.Write("Input a number of the first row: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of the second row: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray, r1, r2);
Show2dArray(newArray);