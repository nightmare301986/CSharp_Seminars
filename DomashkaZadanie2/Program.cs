/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа. Не использовать строки
456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int result1 = (number - number % 100) / 10 + number % 10;

System.Console.WriteLine("Новое число " + result1);