﻿// Задача 009:
// Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа:
// Пример: 78 -> 8
//         12 -> 2
//         85 -> 8


int num = new Random().Next(10, 100);         // ввод рандомной переменной num
Console.WriteLine(num);                       // вывод на печать num
int num1 = num / 10;                          // ввод переменной num1, которая равна num деленному на 10       <- первая цифра
int num2 = num % 10;                          // ввод переменной num2, которая покажет остаток от числа (%10)  <- вторая цифрва

if (num1 > num2)                              // проверкка какая цифра больше
{
    Console.Write("Наибольшая цифра числа {0} равна {1}", num, num1);     // если num1 больше, то выводим на печать...
}
else                                                                      // иначе
{
    Console.Write("Наибольшая цифра числа {0} равна {1}", num, num2);     // если num2 больше, то выводим на печать...
}