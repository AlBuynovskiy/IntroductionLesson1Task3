﻿// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Число является четным.");
}
else
{
    Console.WriteLine("Число является не четным.");
}