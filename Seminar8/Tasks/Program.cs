// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

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

void SwitchRowsToColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

int[,] myFirstArray = CreateRandom2dArray();
Show2dArray(myFirstArray);

SwitchRowsToColumns(myFirstArray);
Show2dArray(myFirstArray);

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[] minValue(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minRow, minColumn])
            {
                minRow = i;
                minColumn = j;
            }
        }
    int[] indexes = { minRow, minColumn };
    return indexes;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[,] ReturnModifiedArray(int[,] array, int[] indexes)
{
    int[,] modifiedArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0, x = 0; i < array.GetLength(0); i++, x++)
    {
        if (indexes[0] == i)
        {
            x--;
            continue;
        }
        else
            for (int j = 0, y = 0; j < array.GetLength(1); j++, y++)
                if (indexes[1] == j)
                {
                    y--;
                    continue;
                }
                else
                    modifiedArray[x, y] = array[i, j];
    }
    return modifiedArray;
}

int[,] mySecondArray = CreateRandom2dArray();
Show2dArray(mySecondArray);
int[] indexes = minValue(mySecondArray);
ShowArray(minValue(mySecondArray));
Show2dArray(ReturnModifiedArray(mySecondArray, indexes));