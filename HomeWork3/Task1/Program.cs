Console.WriteLine("Введите пятизначное целое число: ");
int number = int.Parse(Console.ReadLine());
if (number<0) number = number*(-1);//условие для корректной работы программы с отрицательными числами
if (number<100000&&number>9999)
{ 
// скучное решение в две строки
//if (number/10000==number%10&&(number/1000)%10==(number%100-number%10)/10) Console.WriteLine("Это полиндром!! ");
//else Console.WriteLine("Это обычное число, никакой не полиндром");

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
