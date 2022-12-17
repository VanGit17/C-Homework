Console.WriteLine("Введите любое целое число, а мы покажем его третью цифру: ");
Int64 number = Int64.Parse(Console.ReadLine());
if (number<0) number = number*(-1);//Условие для корректной работы программы с отрицательными числами
if (number>99)
{
   while (number>1000)
                       {
                           number = number/10;
                       }
   
   Console.Write("Третья цифра числа: " + number%10);
  }
else
Console.WriteLine("извините, но у этого числа третьей цифры нет! ");