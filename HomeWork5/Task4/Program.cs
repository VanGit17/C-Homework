/*Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

void ArrayPrint (int[] a)
{
Console.Write("[");
for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
Console.WriteLine($"{a[a.Length-1]}]");
}
int length = new Random().Next(3,11);
int[] Array =new int[length];
int length2=0;
if (length%2==0) length2 = length/2;
else length2 = length/2+1;
int[] ArrayPair =new int[length2];

for (int i=0; i<length; i++) 
{
Array[i] = new Random().Next(-10,10);
}
ArrayPrint(Array);


for (int i=0; i<length/2; i++)
{
  ArrayPair[i]=Array[i]*Array[length-i-1];
}
if(length%2==1) ArrayPair[length2-1]=Array[length/2];
ArrayPrint(ArrayPair);
