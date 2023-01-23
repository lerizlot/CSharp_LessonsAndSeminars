// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    // for(int i = 0; i < array.Length / 2; i++) // идём до середины массива
    // {
    //     // создаем временную переменную в которую записывается левый элемент
    //     int temp = array[i];
    //     // в array[i] записываем тот элемент, с кем меняем текущий элемент
    //     // индекс должен уменьшаться на единицу за каждый повтор цикла
    //     array[i] = array[array.Length - 1 - i];
    //     // последний элемент ставим на место временного
    //     array[array.Length - 1 - i] = temp;
    //}

    // i - в начале цикла, j - в конце и постепенно друг к другу приближаются
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);
