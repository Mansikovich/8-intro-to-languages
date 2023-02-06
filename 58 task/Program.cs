using System;

namespace ConsoleApp
{
class Program
{
static void Main()
{
int[,] Amatrix = new int [2,2];
int[,] Bmatrix = new int [2,2];
FillArray(Amatrix);
FillArray(Bmatrix);
PrintArray(Amatrix);
Console.WriteLine();
PrintArray(Bmatrix);
Console.WriteLine();

int[,] resultMatrix = new int[2,2];
MultiplyMatrix(Amatrix, Bmatrix, resultMatrix);
Console.WriteLine($"Произведение матриц:");
PrintArray(resultMatrix);



void MultiplyMatrix(int[,] Amatrix, int[,] Bmatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Amatrix.GetLength(1); k++)
      {
        sum += Amatrix[i,k] * Bmatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}



void PrintArray(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
     {
        Console.Write($"{matrix[i,j]} ");
     }
     Console.WriteLine();
    }
}    

void FillArray(int[,] matrix)
{

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        matrix[i,j] = new Random().Next(1,10);
    }
    }
}



}
}
}

