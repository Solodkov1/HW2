/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 *

int CutNumber (int num)
{
    int dec = num / 10;
    int sot = num / 100;
    int result = dec - sot*10;
    return result;
}

int number = 945;
int digit = Cutnumber (number);
Console.WriteLine($"your digit {digit}");
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6


int CutDigitThree(int num)
{
    while (num >= 1000) num/= 10;
    int digit = num % 10;
    return digit;    
}
int a = 32;
int number = 0;
if (a >= 100) number = CutDigitThree (a);
if (a < 100)   Console.WriteLine($"You dont have third digit");
if (a >= 100) Console.WriteLine($"you number {number}");
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


void Wikend(int day)
{
    if (day %7 == 0|| day % 6 == 0)
    {
    Console.WriteLine("This is day wikend");
    }
    else 
    { 
    Console.WriteLine("This is workday");
    }
}
Console.WriteLine("Введите число: ");
Wikend(Convert.ToInt32(Console.ReadLine()));