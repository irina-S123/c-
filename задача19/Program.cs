// Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.

Console.WriteLine("Ввидите пятизначное число");
int num = int.Parse(Console.ReadLine()!);

if (num < 10000 || num >= 100000)
    Console.WriteLine($"Не пятизначное число");

else
{
    int a = num / 1000, b = num % 100;
    if ((a / 10 == b % 10) && (a % 10 % 10 == b / 10))
        Console.WriteLine($"Число - палиндром");
    else
        Console.WriteLine($"Число - не палиндром");
}
