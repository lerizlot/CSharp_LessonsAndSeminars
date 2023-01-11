// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int GetQuadrant(int x, int y)
{
    int quadrant = -1;
    if (x > 0 && y > 0) quadrant = 1;
    else if (x < 0 && y > 0) quadrant = 2;
    else if (x < 0 && y < 0) quadrant = 3;
    else if (x > 0 && y < 0) quadrant = 4;

    return quadrant;
}
Console.Write("Input coordinate x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number y: ");
int y = Convert.ToInt32(Console.ReadLine());

int result = GetQuadrant(x, y);

if (GetQuadrant(x, y) == -1) Console.WriteLine("Wrong input");
else Console.WriteLine($"Quadrant number is {result}");

// Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.

void Quad(int N)
{
    int count = 1;
    Console.WriteLine("Squares of numbers are:");

    while (count <= N)
    {
        Console.Write(count * count + " ");
        count = count + 1;
    }

}
Console.WriteLine("Input number N");
int N = Convert.ToInt32(Console.ReadLine());

Quad(N);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Distance(double x1, double y1, double x2, double y2)
{   
    double res1 = Math.Pow(x2 - x1, 2);
    double res2 = Math.Pow(y2 - y1, 2);
    double distance = Math.Sqrt(res1 + res2);
    return distance;
}

Console.WriteLine("Input coordinate x1, y1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate x2, y2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double answer = Distance(x1, x2, y1, y2);
Console.WriteLine(answer);
