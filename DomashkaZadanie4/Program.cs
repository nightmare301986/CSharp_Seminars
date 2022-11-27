/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
Не использовать строки
6 -> да
7 -> да
1 -> нет*/

int Prompt(string message)
{
    System.Console.Write($"{message} >  ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int day = Prompt("Введите день недели с помощью его порядкового номера (1 - понедельник и т.д.");

 switch(day) 
 {
     case 1: System.Console.WriteLine("Понедельник - рабочий (НЕ ВЫХОДНОЙ)"); break;
     case 2: System.Console.WriteLine("Вторник - рабочий (НЕ ВЫХОДНОЙ)");break;
     case 3: System.Console.WriteLine("Среда - рабочий (НЕ ВЫХОДНОЙ)");break;
     case 4: System.Console.WriteLine("Четверг - рабочий (НЕ ВЫХОДНОЙ)");break;
     case 5: System.Console.WriteLine("Пятница - рабочий (НЕ ВЫХОДНОЙ)");break;
     case 6: System.Console.WriteLine("Суббота -  ВЫХОДНОЙ");break;
     case 7: System.Console.WriteLine("Воскресенье -  ВЫХОДНОЙ");break;
     default: System.Console.WriteLine("Ошибка ввода");break;
 }
