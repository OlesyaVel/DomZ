﻿// Задание №1.
// По двум заданным числам проверять является ли первое квадратом второго.

Console.Write("Введите первое число: ");  // строка для первого запроса
int a = int.Parse(Console.ReadLine()!);      // новая строка для ввода данных

Console.Write("Введите второе число: ");  // строка для второго запроса
int b = int.Parse(Console.ReadLine()!);      // новая строка для ввода данных

if (b*b==a)  // Если. Формула вывода квадратного числа. Пример: Если 5*5 строго равно 25, то:
 Console.WriteLine("Первое число явлется квадратом второго! "); // То выводится эта строка.


else // Иначе. То есть, если 1е условие "НЕТ" то выполняется "ИНАЧЕ"
Console.WriteLine(" нет! "); // Вывод иначе.