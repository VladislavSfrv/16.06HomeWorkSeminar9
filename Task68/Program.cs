//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите два числа: ");
int numM = Convert.ToInt32(Console.ReadLine());
int numN = Convert.ToInt32(Console.ReadLine());

int result = Ackerman(numM, numN);
Console.WriteLine($"Ваше число в функции Аккермана -> {result}");

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ackerman(m - 1, 1);
    if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    return Ackerman(m, n);
}