﻿/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа. Не использовать строки
456 -> 46
782 -> 72
918 -> 98
*/
//Генерируем псевдослучайное трехзначное число
int number = new Random().Next(100, 1000);
Console.WriteLine(number);

//Убираем 2-ую цифру из трехзначного числа (разряд десятков)
int result1 = (number - number % 100) / 10 + number % 10;

//Выводим получившееся число
System.Console.WriteLine("Новое число " + result1);