/* Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
void ArrayPrint (int[] a)
{
Console.Write("[");
for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
Console.WriteLine($"{a[a.Length-1]}]");
}
int length = new Random().Next(3,11);
int[] Array =new int[length];
int count = 0;

for (int i=0; i<Array.Length; i++) 
{
Array[i] = new Random().Next(0,1000);
}
ArrayPrint(Array);


for (int i=0; i<Array.Length; i++)
{
    if (Array[i]%2==0) 
    {
        count +=1;
    }
   
}
 Console.WriteLine("Количество чётных чисел в массиве: "+count);


