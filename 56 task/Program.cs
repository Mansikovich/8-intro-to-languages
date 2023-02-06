using System;

namespace ConsoleApp
{
class Program
{
static void Main()
{
int[,] matrix = new int [4,4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

int MinSumRow = 0;
int SumRow = SumRowElements(matrix,0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumRow = SumRowElements(matrix, i);
  if (SumRow > tempSumRow)
  {
    SumRow = tempSumRow;
    MinSumRow = i;
  }
}

Console.WriteLine($"\n{MinSumRow+1} - строкa с наименьшей суммой ({SumRow}) элементов ");



int SumRowElements(int[,] matrix, int i)
{
  int SumRow = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    SumRow += matrix[i,j];
  }
  return SumRow;
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
        matrix[i,j] = new Random().Next(1,100);
    }
    }
}



}
}
}

