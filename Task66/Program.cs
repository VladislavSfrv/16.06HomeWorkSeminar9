// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа: ");
int numM = Convert.ToInt32(Console.ReadLine());
int numN = Convert.ToInt32(Console.ReadLine());

int result = SumElement(numM, numN);
Console.WriteLine(result > 0 ? result : "Введите число больше 0.");

int SumElement(int numM, int numN)
{
    if(numM > 0 && numN > 0)
    {
        if (numM == numN) return numM;
        return numM + SumElement(numM + 1, numN);
    }else return -1;
}