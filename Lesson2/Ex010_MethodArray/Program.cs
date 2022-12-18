int[] array = { 13, 22, 43, 74, 55, 16, 97, 48 };

int n = array.Length;
int find = 55;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}