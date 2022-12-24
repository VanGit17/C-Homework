/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
Пример:
0, 7, 8, -2, -2 -> 2*/
Console.WriteLine("введите ряд чисел, через пробел, а мы посчитаем сколько из них больше нуля:");
string row = Console.ReadLine();
string[] numbers = row.Split(' ');
int count =0;

for(int i = 0; i<numbers.Length; i++)
{
    if(Convert.ToInt16(numbers[i])>0) count +=1;
}
 
 Console.WriteLine("Положительных чисел в ряду: " + count);