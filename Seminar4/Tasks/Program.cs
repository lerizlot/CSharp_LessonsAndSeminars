// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int GetQuantity(int num)
{
    int quantity = 0;
   
    while (num != 0)
    {
        num = num / 10;
        quantity++;
    }
    return quantity;
}
Console.Write("Task 1. Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result1 = GetQuantity(num);
Console.WriteLine(result1);

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int GetProduct (int n)
{
    int product = 1;

    for (int i = 1; i <= n; i++)
        product *= i;
    return product; 
}

Console.Write("Task2. Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int result2 = GetProduct(n);
Console.WriteLine(result2);