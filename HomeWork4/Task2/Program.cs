/*Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
Console.WriteLine("Введите число: ");
Int64 number = Int64.Parse(Console.ReadLine());
Int64 sum = 0;
if (number<0) number=number*(-1);
while (number>=10)
{
    sum =sum+number%10;
    number = number/10; 
}
sum = sum + number;
    Console.WriteLine("Сумма цифр в числе: "+sum);