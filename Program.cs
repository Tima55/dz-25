﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write(" Введите число ");
int number  = Convert.ToInt32(Console.ReadLine());
if(number < 1000)
{
    if(number > 99)
    {
     int lastDigit = number / 10;
 int answer = lastDigit % 10;
Console.WriteLine("Вторая  цифра " + answer);
    
    }
}