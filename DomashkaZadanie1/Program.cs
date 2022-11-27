/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
Не использовать строки
456 -> 5
782 -> 8
918 -> 1
422 -> 2*/
//Запрос числа
int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
//Проверка числа на 3-хзначность
bool ValidateNumber(int number)
{
    if (number >= 100 && number < 1000)
    {
        return true;
    }

    System.Console.WriteLine("Число не трехзначное");
    return false;
}
//Выполнение в программе
int number = Prompt("Введите число");
if (ValidateNumber(number))
{
    int result = (number % 100 - number % 10) / 10;
    System.Console.WriteLine($"Вторая цифра введенного числа {result}");
}

