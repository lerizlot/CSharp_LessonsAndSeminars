int a = 5;
double b = 3.14;
bool c = true; // false
string d = "строка";

// два варианта конкатенации
Console.WriteLine("My number is " + a);
Console.WriteLine($"My number is {a}");

// два вида вывода в консоль
Console.Write("Good morning! ");
Console.WriteLine("Have a nice day! ");

Console.WriteLine("Input a number: ");
// преобразование типа
int number = Convert.ToInt32(Console.ReadLine());

// остаток от деления %

/*
37145 / 10 = 3714
37145 / 100 = 371
37145 / 1000 = 37
37145 / 10000 = 3
37145 / 100000 = 0

37145 % 10 = 5
37145 % 100 = 45
37145 % 1000 = 145
37145 % 10000 = 7145
*/
