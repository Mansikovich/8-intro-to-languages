using System;

namespace ConsoleApp
{
class Program
{
static void Main()
{
int[,,] matrix3d = new int [2,2,2];
FillArray(matrix3d);
PrintArray(matrix3d);
int element=int.Parse(Console.ReadLine());

void FillArray(int[,,] matrix3d)

{

    for(int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++) 
         {
        for (int k = 0; k < matrix3d.GetLength(2); k++) 
    {
        matrix3d[i,j,k] = new Random().Next(10,100);
    }
        }
    }
}
    

void PrintArray (int[,,] matrix3d)
{
  for (int i = 0; i < matrix3d.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3d.GetLength(1); j++)
    {
          for (int k = 0; k < matrix3d.GetLength(2); k++)
      {
        Console.Write( $"{matrix3d[i,j,k]}({i},{j},{k})");
      }
      Console.WriteLine();
    }
        
       
} 

      }
    }
  }
}



