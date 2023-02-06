// Напишите программу, которая выводит третью
//цифру заданного числа или сообщает,что третьей цифры нет.
Console.Clear();

Console.WriteLine("Ввидите трехзначное число");
int num = int.Parse(Console.ReadLine()!);
if (num < 100 || num == 0)
{
    Console.WriteLine("Цифра меньше 100 или ровна 0 - третьей цифры нет");
}
while (num > 1000)
{
    num /= 10;
}
if(num > 100)
{
    num = num % 10;
    Console.WriteLine($"Третья цифра: {num}");
}