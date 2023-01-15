// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++) 
    // 1 - рабочая переменная; 2 - до каких пор цикл будет идти; 3 - 
        sum += current;
    return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine(result);