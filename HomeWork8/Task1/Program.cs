/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
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

int row = new Random().Next(3,10);
int column = new Random().Next(3,10);
int[,] Matrix = new int[row,column];
FillMatrixRandom(Matrix);
Console.WriteLine("Дан массив:");
PrintMatrix(Matrix);
int min = 0;

    for (int i=0; i<Matrix.GetLength(0); i++) 
{
     for (int k=0;k<Matrix.GetLength(1)-1;k++)   
    {
    min = Matrix[i,0];
    for (int j=0; j<Matrix.GetLength(1); j++)
    {
   
   if(Matrix[i,j]<=min) 
   {
    min = Matrix[i,j];
   }
   else 
   Matrix[i,j-1] = Matrix[i,j];
   Matrix[i,j] =min;

    
    }
    }
}
Console.WriteLine("Отсортированный массив:");
PrintMatrix(Matrix);