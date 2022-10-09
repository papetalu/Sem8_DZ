// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
Console.Clear();

void InputMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = new Random().Next(0, 101);
         //Console.Write(matrix[i, j] + " \t");
      }
      //Console.WriteLine();
   }
}

void PrintMatrix(int[,] inMatrix)
{
   for (int i = 0; i < inMatrix.GetLength(0); i++)
   {
      for (int j = 0; j < inMatrix.GetLength(1); j++)
      {
         Console.Write(inMatrix[i, j] + " \t");
      }
      Console.WriteLine();
   }
}

void NewMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {

      for (int j = 1; j < matrix.GetLength(1); j++)
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


Console.Write("Введите кол-во строк таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine(" ");
NewMatrix(matrix);
PrintMatrix(matrix);

