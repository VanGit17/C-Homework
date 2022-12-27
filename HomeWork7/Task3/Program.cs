/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
*/
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

double sum = 0;
 for (int i=0; i<Matrix.GetLength(1); i++) 
{
    for (int j=0; j<Matrix.GetLength(0); j++)
    {
      sum +=Matrix[j,i];
      if (j==Matrix.GetLength(0)-1) 
       {
        Console.WriteLine($"Среднее арифметическое в столбце {i} равно:  "+ Math.Round(sum/Matrix.GetLength(0) ,1));
       sum =0;
       }

    }
}

