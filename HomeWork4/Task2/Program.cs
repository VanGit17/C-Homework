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
    

/*Решение задачи через работу со строкой
(возникли сложности с переводом символа строки в число напрямую, без дополнительной строковой переменной
, Convert.ToInt16(number[i]) прибавлял каждый раз 48 к числовому значению number[i])
   
   
    Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int sum=0;
string a=string.Empty ;

for (int i=0;i<number.Length; i++)
{
    a =Convert.ToString(number[i]);
    sum = sum + Convert.ToInt16(a);
}
 Console.WriteLine("Сумма цифр в числе: "+sum);
 */