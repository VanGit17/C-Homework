/*
Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int row =new Random().Next(2,5);
int column = new Random().Next(2,5);
int depth = new Random().Next(2,5);
int[,,] threeDemMatrix = new int [row,column,depth];

Console.WriteLine("Трехмерный массив, с индексами каждого элемента: ");
for (int i = 0; i <threeDemMatrix.GetLength(0); i++)
{
    for (int j = 0; j <threeDemMatrix.GetLength(1); j++)
    {
        for (int k = 0; k <threeDemMatrix.GetLength(2); k++)
        {
            threeDemMatrix[i,j,k] = new Random().Next(10,100);
         Console.Write($"{threeDemMatrix[i,j,k] }({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}
