// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result;
}

int randNumber = new Random().Next(100,1000);
Console.WriteLine("Current random three-digit number is " + randNumber);

int newNumber = CutNumber(randNumber);
Console.WriteLine("New version of number is " + newNumber);