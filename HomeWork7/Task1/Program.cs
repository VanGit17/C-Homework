/*Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами от -10,0 до 10,0.
m = 3, n = 4.
0,5 7,0 -2,0 -0,2
1,0 -3,3 8,0 -9,9
8,0 7,8 -7,1 9,0*/

void PrintMatrix (double[,] matrix)
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

int row = new Random().Next(3,7);
int column = new Random().Next(3,7);
double[,] Matrix =new double[row,column];

for (int i=0; i<Matrix.GetLength(0); i++) 
{
    for (int j=0; j<Matrix.GetLength(1); j++)
    {
      Matrix[i,j] = (new Random().Next(-100,101)/10.0);

    }
}
PrintMatrix(Matrix);