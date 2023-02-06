using System;

namespace ConsoleApp
{
class Program
{
static void Main()
{


int n = 4;
int [,] matrix = new int [n,n];


int temp = 1;
int i = 0;
int j = 0;

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
  matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

FillArray(matrix);

void FillArray(int [,] matr)
{

    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
    {
        if (matrix[i,j] / 10 <= 0)
        Console.Write($" {matrix[i,j]} ");

        else Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
    }
}
}
}
}
