/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.
Формулы нахождения координат x и y точки пересечения:
x = (b2-b1)/(k1-k2);
y = k1*x+b1;
Пример:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.WriteLine("Введите через пробел коэффициенты k1 b1 первой прямой и к2 b2 второй прямой, а мы найдём точку пересечения:");
string Text = Console.ReadLine();
string[] indexes = Text.Split(' ');
double[] NuberIndexes = new double[indexes.Length]; 
double x =0;
double y = 0;
for(int i=0; i<indexes.Length; i++) 
{
    NuberIndexes[i]=Convert.ToDouble(indexes[i]);
}

Console.WriteLine($"Ваши коэффициенты задают прямые:\n y1 = {NuberIndexes[0]}*x + {NuberIndexes[1]} \n y2 = {NuberIndexes[2]}*x + {NuberIndexes[3]}");
x=Math.Round((NuberIndexes[3]-NuberIndexes[1])/(NuberIndexes[0]-NuberIndexes[2]),2);
y=Math.Round(NuberIndexes[0]*x + NuberIndexes[1],2);
//x = (b2-b1)/(k1-k2);
//y = k1*x+b1;
Console.WriteLine($"Точка пересечения прямых имеет координаты: ({x};{y})");