// : Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введте число: ");
int a = int.Parse(Console.ReadLine()!);
int count = 1;

while (count <= a)
{
    Console.Write(count * count * count);
    if (count != a) Console.Write(", ");
    count++;
}
