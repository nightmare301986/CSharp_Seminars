/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. . 
Не использовать строки
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

//Ввод числа
int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

//Отработка функции ввода
int number = Prompt("Введите число");

//Проверка на 3-хзначность
if (number < 100)
{
    System.Console.WriteLine("Третьей цифры у такого числа нет");
}

//Проверка максимального дмъиапазона переменных в программе
if (number >= 999999999)
{
    System.Console.WriteLine("Такие числа не входят в диапазон переменных программы");
}

//Условие и нахождение 3-го числа (без использования строк только математически) 
//Условие для 3-хзначного числа
if (number >= 100 & number < 1000)
{
    int result = number % 10;
    System.Console.WriteLine("Третья цифра у числа  " + result);
}
else //Условие для чисел больше 3-хзначных
{
    int n = 100;

    while (n < 999999999)
    {
        int number2 = number / n;
        if (number2 >= 10 & number2 <= 100)
        {
            double result = (number % n - number % (n / 10)) / (n / 10);
            if (number2 == 100) //Дополнительный шаг для некоторых чисел (пример:100258, 100894 и т.д.)
            {
                result = 0;
                System.Console.WriteLine("Третья цифра у числа  " + result);
                break;
            }
            System.Console.WriteLine("Третья цифра у числа  " + result);
        }
        n = n * 10;
    }

}