Console.WriteLine("Введите трехзначное целое число: ");
int number = int.Parse(Console.ReadLine());
if (number<0) number = number*(-1);//Условие для корректной работы программы с отрицательными числами
if (number>99&&number<1000)
{
   int a = (number/10)%10; 
   
   Console.Write("Вторая цифра числа: " + a);
 
 }
else
Console.WriteLine("извините, но это не трехзначное число, мы так не работаем! ");


