/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

void ArrayPrint (int[] a)
{
Console.Write("[");
for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
Console.WriteLine($"{a[a.Length-1]}]");
}
int length = new Random().Next(3,11);
int[] Array =new int[length];

for (int i=0; i<Array.Length; i++) 
{
Array[i] = new Random().Next(-100,101);
}
ArrayPrint(Array);

int max = Array[0];
int min = Array[0];


for (int i=0; i<Array.Length; i++)
{
    if (Array[i]>max) max = Array[i];
    if (Array[i]<min) min = Array[i];
}
 Console.WriteLine("Разница между максимальным и минимальным лементом массива: "+(max-min));