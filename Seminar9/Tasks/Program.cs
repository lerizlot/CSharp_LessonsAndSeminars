// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNums(int M, int N)
{
    if(M > N)
    {
        Console.Write(M + " ");
        ShowNums(M - 1, N);
    }
    else if (M < N) ShowNums(M, N - 1);
    else Console.WriteLine(N + " ");
}

ShowNums(3,9);

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double Method(double A, double B)
{
    if(B>0) return A*Method(A, B -1);
    else if (B < 0) return (1/A)*Method(A, B+1);
    else return 1;
}

Console.WriteLine(Method(2, -3));
