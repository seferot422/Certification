﻿Console.Write("Пожалуйста, Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"Функция Аккермана равна {akkerman(m, n)} ");
