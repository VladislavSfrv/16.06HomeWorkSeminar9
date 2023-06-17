//Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumber(num);

void PrintNaturalNumber(int num)
{
    if (num > 0)
    {
        Console.Write($"{num} ");
        if (num == 1) return;
        PrintNaturalNumber(num - 1);
    }else Console.WriteLine("Введите число больше 0.");
}