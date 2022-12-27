/*Напишите программу, которая на вход принимает число, и возвращает 
индексы числа в двумерном массиве или же указание, что такого элемента нет.
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
      matrix[i,j] = new Random().Next(-10,16);

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

Console.WriteLine("Укажите число, а мы проверим, есть ли оно в массиве и назовём его индекс: ");
int number = int.Parse(Console.ReadLine());

bool numberFound=false;
 for (int i=0; i<Matrix.GetLength(0); i++) 
{
    for (int j=0; j<Matrix.GetLength(1); j++)
    {
     if(Matrix[i,j]==number) 
     {Console.WriteLine($"Число встретилось в массиве, его индексы, строка:{i}, столбец:{j}");
    numberFound = true;
     }
    }
}
    
if (numberFound);
else Console.WriteLine("Такого числа в массиве нет");

