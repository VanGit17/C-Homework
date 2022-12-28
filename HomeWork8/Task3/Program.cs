/*Задайте два двумерных массива (от 0 до 10). Напишите программу,
которая будет находить произведение двух массивов (поэлементное).
Например, даны 2 массива:
2 4
3 2

3 4
3 3
Результирующая матрица будет:
6 16
9 6*/
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
      matrix[i,j] = new Random().Next(0,11);

    }
}
return matrix;
}

int row = new Random().Next(3,7);
int column = new Random().Next(3,7);
int[,] Matrix1 = new int[row,column];
FillMatrixRandom(Matrix1);
Console.WriteLine("Дан первый массив:");
PrintMatrix(Matrix1);

int[,] Matrix2 = new int[row,column];
FillMatrixRandom(Matrix2);
Console.WriteLine("Дан второй массив:");
PrintMatrix(Matrix2);

int[,] MatrixMulyiply = new int[row,column];

for (int i = 0; i < MatrixMulyiply.GetLength(0); i++)
{
    for (int j = 0; j <MatrixMulyiply.GetLength(1); j++)
    {
        MatrixMulyiply[i,j]=Matrix1[i,j]*Matrix2[i,j];
    }

}
Console.WriteLine("Результирующая матрица поэлементного произведения 1го и 2го массивов:");
PrintMatrix(MatrixMulyiply);