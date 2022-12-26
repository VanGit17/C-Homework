/*Доп. задача Напишите программу, 
которая будет преобразовывать десятичное число в двоичное.
Пример:
45 -> 101101
3 -> 11
2 -> 10*/

Console.WriteLine("Введите число в десятичной системе: ");
int number = int.Parse(Console.ReadLine());
int Length =0;
int counter = number;
 //int k = Convert.ToInt16(Math.Log(number,2)) ;
 ///Console.WriteLine(k);
while(counter>0)
{
Length++;
counter = counter/2;
}

if(Length==0) Length = 1; 
int[] ZeroOneNumber = new int[Length];
for(int i =0; i<Length;i++)
{
ZeroOneNumber[Length-1-i]=number%2;
number = number/2;

}
Console.WriteLine("Число в двоичной системе: ");
for(int i =0; i<Length;i++)
{
  Console.Write(ZeroOneNumber[i]);
}
Console.WriteLine();
Console.WriteLine(Length);
//Console.WriteLine(Math.Log(number,2));