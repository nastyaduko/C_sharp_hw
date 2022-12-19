﻿//Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 
//3-х знаков

Console.WriteLine("Введите трехзначное число:");
int num1 = int.Parse(Console.ReadLine()!);
if(((num1 >= 100)&&(num1 < 1000)||(num1 > -1000)&&(num1 <= -100)))
{
if(num1 > 0)
Console.WriteLine($"Второй цифрой введенного трехзначного числа является {(num1/10)%10}");
else
{Console.WriteLine($"Второй цифрой введенного трехзначного числа является {(num1/10)%10*(-1)}");}
}
else{Console.WriteLine("Введеное число не является трехзначным");}

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Берем числа до 100000

//Вариант 1. Покороче
Console.WriteLine("Введите число от 0 до 100 000:");
int num21 = int.Parse(Console.ReadLine()!);
if((num21 > -1)&&(num21 < 100000))
{
    string str = num21.ToString();
    int size = str.Length;
    if(size > 2)
    {Console.WriteLine($"третья цифра во введенном числе {str[2]}");}
    else {Console.WriteLine("третей цифры во введенном числе нет");}
}
else{Console.WriteLine("Введенное число не лежит в указанном интервале");}

//Вариант 2. 
Console.WriteLine("Введите число от 0 до 100 000:");
int num22 = int.Parse(Console.ReadLine()!);
if ((num22 > -1) && (num22 < 100000))
{
    if (num22 < 100) {Console.WriteLine($"третей цифры во введенном числе нет");}
    else if ((num22 >= 100) && (num22 < 1000)) 
    {Console.WriteLine($"третья цифра во введенном числе {num22%10}");}
    else if ((num22 >= 1000) && (num22 < 10000)) 
    {Console.WriteLine($"третья цифра во введенном числе {num22%100/10}");}
    else if ((num22 >= 10000) && (num22 < 100000)) 
    {Console.WriteLine($"третья цифра во введенном числе {num22%1000/100}");}
}
else{Console.WriteLine("Веденное число не лежит в заданном интервале");}

//Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

Console.WriteLine("Введите порядковый номер дня недели:");
int num3 = int.Parse(Console.ReadLine()!);
if((num3 >= 1)&&(num3 <= 7))
{
if(num3<6) {Console.WriteLine("Данный день не является выходным");}
else{Console.WriteLine("Это выходной!!!");}
}
else {Console.WriteLine("Введенное число не соответствует порядковому номеру дня недели");}