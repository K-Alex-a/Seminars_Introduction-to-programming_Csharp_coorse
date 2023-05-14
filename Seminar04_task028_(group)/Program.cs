﻿// Задача 028 (*в группе*):
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число A: ");         // запрос ввода числа
int A = Convert.ToInt32(Console.ReadLine());      // создаем переменную n, в которую вкладываем введенное число

int Mul(int num)                            // создание массива
{
    int sum = 1;                            // внутри массива создаем переменную sum со стартовым значением 1
    for (int i = 1; i <= num; i++)          // пока i меньше или равно введенному числу, то делаем ->
    {
        sum *= i;                           //  нашу sum умножаем на введенное нами число
    }
    return sum;                             // выводим результат
}

Console.WriteLine($"Произведение чисел от 1 до {A} равна {Mul(A)}");     // выводим на печать результат