/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/
void ArrayPrint (int[] a)
{
Console.Write("[");
for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
Console.WriteLine($"{a[a.Length-1]}]");
}
int length = new Random().Next(3,11);
int[] Array =new int[length];
int sum = 0;

for (int i=0; i<Array.Length; i++) 
{
Array[i] = new Random().Next(-15,16);
}
ArrayPrint(Array);


for (int i=0; i<Array.Length; i++)
{
    if (i%2>0) 
    {
        sum +=Array[i];
    }
   
}
 Console.WriteLine("Сумма элементов, стоящих нанечётных позициях: "+sum);
