﻿Console.WriteLine("Введите пятизначное целое число: ");
int number = int.Parse(Console.ReadLine());
if (number<0) number = number*(-1);
if (number<100000&&number>9999)
{  
      int[] array = new int[5];
      for (int i = 4; i >=0; i--) 
         {
          array[i] = number%10;
          number = number/10;
         }
      if (array[0]==array[4]&&array[1]==array[3]) Console.WriteLine("Это полиндром!! ");
      else Console.WriteLine("Это обычное число, никакой не полиндром");
}
else Console.WriteLine("Это не пятизначное число!");