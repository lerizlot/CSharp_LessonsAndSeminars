// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());

if (b * b == a)
    Console.WriteLine("Число a является квадратом числа b");
else
    Console.WriteLine("Число a не является квадратом числа b");

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = -N;

while (current <= N)
{
    Console.Write(current + " ");
    current++;
}
Console.WriteLine();

// альтернативный вариант решения через цикл for
for (int i = -N; i <= N; i++)
    Console.Write(i + " ");
