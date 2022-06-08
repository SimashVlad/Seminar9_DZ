﻿/* 
Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 
*/

Console.Clear();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");


int InputNumbers(string input)
{
    Console.Write(input);
    int output = int.Parse(Console.ReadLine());
    return output;
}

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}
