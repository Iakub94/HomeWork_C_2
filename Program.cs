// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Clear();
Console.Write("Введите 3х значное число: ");

int secondNum = Convert.ToInt32(Console.ReadLine());

if (secondNum >= 1000 || secondNum < 100)
{
    Console.WriteLine("Это не 3х значное число!");
}
    if (secondNum > 100 && secondNum < 1000)
    {
        int ed = secondNum % 10;
        int sot = secondNum / 100;
        
        int result = (secondNum - (sot*100+ed))/10;
        Console.WriteLine(result);
    }
*/

// Задача 2. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Clear();
Console.Write("Input numberDay: ");

int day = Convert.ToInt32(Console.ReadLine());

{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Day off");
    }
    else if (day < 1 || day > 7)
    {
        Console.WriteLine("there is no such day");
    }
    else Console.WriteLine("Work day");
}
*/

// Задача 3. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Clear();

int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }

Console.Write("Ведите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра: {ThirdDigit(number1)}");
*/