// Подсчитать сумму цифр в числе

Console.WriteLine("Ввидите число");

int num = int.Parse(Console.ReadLine()!);
int sum = 0;
for (int n = num; n > 0; sum += n % 10, n /= 10)
    Console.WriteLine(sum);
