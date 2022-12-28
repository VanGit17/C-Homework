/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/
//решение заполняет спирально массив произвольнй размерности.
void PrintMatrix (int[,] matrix)
{
for (int i=0; i<matrix.GetLength(0); i++) 
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
            
      if(matrix[i,j]<10) Console.Write("   "+matrix[i,j]);
      else Console.Write("  "+matrix[i,j]);
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

int row = new Random().Next(3,12);
int column = new Random().Next(3,12);
int[,] Matrix = new int[row,column];
Console.WriteLine("Дан массив:");
PrintMatrix(Matrix);

int counter = 1;
bool fillRight = true;
bool fillDown = false;

int j=0,k=0;
while (counter <Matrix.GetLength(0)*Matrix.GetLength(1))
{
   
    if (fillRight&&!fillDown) 
    {
        while(k<Matrix.GetLength(1)&&Matrix[j,k]==0)
        {
          Matrix[j,k] = counter;
          counter++;
          k++; 
        }
       fillDown = true;      
           j=j+1;  
           k-=1;
    
     }
      
     
      if (fillRight&&fillDown) 
    {
    
        while(j<Matrix.GetLength(0)&&Matrix[j,k]==0)
        {
          Matrix[j,k] = counter;
          counter++;
          j++; 
        }
        j=j-1;
        k=k-1;
      fillRight = false;        
    
     }

 if (!fillRight&&fillDown) 
    {
    
        while(k>=0&&Matrix[j,k]==0)
        {
          Matrix[j,k] = counter;
          counter++;
          k--; 
        }
        j=j-1;
        k=k+1;
     fillDown = false;        
    
     }
if (!fillRight&&!fillDown) 
    {
    
        while(Matrix[j,k]==0)
        {
          Matrix[j,k] = counter;
          counter++;
          j--; 
        }
       j=j+1;
       k=k+1;
     fillRight = true;        
    
     }



}
Console.WriteLine("Заполненный массив:");
PrintMatrix(Matrix);

