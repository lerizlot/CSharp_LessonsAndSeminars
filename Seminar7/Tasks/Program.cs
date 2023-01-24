// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

void CreateAndPrintMatrix()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

CreateAndPrintMatrix();

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateMatrix()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);

    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] IsEvenIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
        for (int j = 0; j < matrix.GetLength(1); j += 2)
            matrix[i, j] = matrix[i, j] * matrix[i, j];
    return matrix;
}

int[,] mySecondMatrix = CreateMatrix();
ShowMatrix(mySecondMatrix);
IsEvenIndex(mySecondMatrix);
ShowMatrix(mySecondMatrix);

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int SumOfElements(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i ++)
    sum += matrix[i,i];
    return sum;
}

int[,] myThirdMatrix = CreateMatrix();
ShowMatrix(myThirdMatrix);
int sum = SumOfElements(myThirdMatrix);
Console.WriteLine(sum);