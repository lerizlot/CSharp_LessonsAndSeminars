// Напишите программу, которая выводит случайное число из отрезка [10, 99]и показывает наибольшую цифру числа

int Number (int number)
{
    int des = number / 10;
    int ed = number % 10;
    int max = 0;

    if (des <= ed) max = ed;
    else if (des >= ed) max = des;

    return max;
}

int randNumber = new Random().Next(10, 99);
Console.WriteLine(randNumber);

int answer = Number(randNumber);
Console.WriteLine(answer);

// Напишите программу, которая будет принимать на вход два числа и определять, является ли второе число кратным первому.

bool Method(int a, int b)
{
    if (b % a == 0) return true;
    else return false;
}

Console.WriteLine("Input number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b: ");
int b = Convert.ToInt32(Console.ReadLine());

bool result = Method(a, b);
Console.WriteLine(result);

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool Square(int num1, int num2)
{
    if (num1 == num2 * num2 || num2 == num1 * num1) return true;
    else return false;
}

Console.Write("Input number one: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number two: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (Sqrt(num1, num2))
    Console.WriteLine("One of the numbers is the square of the other number");
else
    Console.WriteLine("None of the numbers is the square of another number");
