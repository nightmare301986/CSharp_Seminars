/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. . 
Не использовать строки
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int number = Prompt("Введите число");

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры у такого числа нет");
}

if (number >= 999999999)
{
    System.Console.WriteLine("Такие числа не входят в диапазон переменных программы");
}

if (number >= 100 & number < 1000)
{
    int result = number % 10;
    System.Console.WriteLine("Третья цифра у числа  " + result);
}
else
{
    int n = 100;

    while (n < 999999999)
    {
        int number2 = number / n;
        if (number2 >= 10 & number2 <= 100)
        {
            double result = (number % n - number % (n / 10)) / (n / 10);
            if (number2 == 100)
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