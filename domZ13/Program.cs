﻿
// Задача №13.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
string numStr = $"{number}";
int ln = numStr.Length;

if (ln >= 3 )
{
    Console.Write("Третье число = ");
    Console.Write(numStr[2]);
}
else
    Console.Write("третьей цифры нет");