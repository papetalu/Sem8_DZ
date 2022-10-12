// Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
Console.Clear();
Console.Write("Введите кол-во строк таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[n, m];
int[,] matrix2 = new int[n, m];
int[,] productMatrix = new int[n, m];
InputMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine(" ");
InputMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine(" ");
Console.WriteLine("Произведение двух матриц: ");
ProductMatrix(productMatrix);
PrintMatrix(productMatrix);


void InputMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = new Random().Next(0, 101);

      }

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


void ProductMatrix(int[,] matrix)
{

   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         productMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
      }

   }

}


