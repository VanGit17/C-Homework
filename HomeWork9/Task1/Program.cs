/*Задайте значение N. Напишите программу, которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите N:");

int n = int.Parse(Console.ReadLine());

string PrintNumbers (int Number)
{
    if(Number == 1) return "1";
    return (Number + ", " + PrintNumbers ( Number-1) );
}


Console.WriteLine("Вот все натуральные числа в промежутке от N до 1:");
Console.Write(PrintNumbers(n));