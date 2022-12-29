/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int CountSum (int start, int end)
{
    if(start == end) return end;

    
    return start + CountSum(start+1,end);
}
Console.Write("Вот сумма натуральных элементов в промежутке от M до N: " + CountSum(m,n));
//Console.Write(CountSum(m,n));