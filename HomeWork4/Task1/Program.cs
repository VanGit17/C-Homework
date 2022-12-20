/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
Не используя Math.Pow!
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
//Решено для любой целой степени, не только для натуральной
Console.WriteLine("Введите число А: ");
double A = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
if(B==0)  Console.WriteLine("Число A в степени B равно: 1");
if (B>0)
{
    double C=A;
    for (int i=2; i<=B;i++) C=C*A;
    Console.WriteLine("Число A в степени B равно: "+C);
}
if (B<0)
{
    double C=1/A;
    B=B*(-1);
    for (int i=2; i<=B;i++) C=C/A;
    Console.WriteLine("Число A в степени B равно: "+C);
}
