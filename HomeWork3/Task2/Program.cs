/*Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Найдём расстояние между точками в трехмерном пространстве: ");
Console.WriteLine("Введите координаты первой точки: x1, y1, z1: ");

Console.Write("x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("z1: ");
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x1: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("y1: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("z1: ");
double z2 = double.Parse(Console.ReadLine());

double SqDiff (double a,double b)
{
    return Math.Pow(a-b,2);
}

double distance = Math.Sqrt(SqDiff(x1,x2)+SqDiff(y1,y2)+SqDiff(z1,z2));
Console.WriteLine("Расстояние между точками: " + distance);

