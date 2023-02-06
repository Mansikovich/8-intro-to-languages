using System;

namespace ConsoleApp
{
class Program
{
static void Main()
{
int[,] matrix = new int [3,4];
FillArray(matrix);
Console.WriteLine();
SortToLower(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

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
void SortToLower(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}


}
}
}

