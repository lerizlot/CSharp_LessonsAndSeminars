// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void ShowNums(int num)
{
    if (num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

ShowNums(5);

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int GetSumOfDigits(int num)
{
    if (num != 0) return GetSumOfDigits(num / 10) + num % 10;
    else return 0;
}
Console.WriteLine(GetSumOfDigits(1234));
