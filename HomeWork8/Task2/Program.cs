/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка*/

void PrintMatrix (int[,] matrix)
{
for (int i=0; i<matrix.GetLength(0); i++) 
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
            
      if(matrix[i,j]>=0 ) Console.Write("  "+matrix[i,j]);
      else Console.Write(" "+matrix[i,j]);
    }
    Console.WriteLine();
}
}
int[,]  FillMatrixRandom(int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++) 
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
      matrix[i,j] = new Random().Next(0,16);

    }
}
return matrix;
}

int row = new Random().Next(5,8);
int column = new Random().Next(3,5);
int[,] Matrix = new int[row,column];
FillMatrixRandom(Matrix);
Console.WriteLine("Дан массив:");
PrintMatrix(Matrix);

int sum =0;
int sumMin =0;
int indexMin=0;

    for (int i=0; i<Matrix.GetLength(0); i++) 
{
    sum=0;
    for (int j=0; j<Matrix.GetLength(1); j++)
    {
     sum+=Matrix[i,j];
    }
    //Console.WriteLine($"Сумма {i+1} строки: {sum}");
    if (i==0) sumMin=sum;
    if (sum<sumMin)
    {
       sumMin=sum; indexMin=i+1;
    }

}
Console.WriteLine($"Строка с наименьшей суммой элементов: {indexMin}");
