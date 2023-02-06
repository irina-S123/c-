// Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.
Console.WriteLine("Ввидите цифру от 1 до 7");
int day = int.Parse(Console.ReadLine()!);

if (day > 0 && day < 6)
{
    Console.WriteLine($"Рабочий день");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine($"Выходной день");
}
