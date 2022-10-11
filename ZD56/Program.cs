// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
Console.Write("Введите кол-во строк таблицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов таблицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[] sumMatrix = new int[n];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine(" ");
Console.WriteLine("Суммы строк: ");
RowSum(matrix);
Console.WriteLine(" ");

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


void RowSum(int[,] matrix)
{
   
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      sumMatrix[i] = 0;
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         sumMatrix[i] = sumMatrix[i] + matrix[i,j];
      }
      Console.Write(sumMatrix[i] + " \t");
   }
   
}

int min = sumMatrix[0];
int tmp = 0;
for (int i = 1; i < sumMatrix.Length; i++)
{
   if (min > sumMatrix[i])
   {
      min = sumMatrix[i];
      tmp = i;
   }
}

Console.WriteLine("Минимальная сумма: ");
Console.WriteLine(min);
Console.WriteLine("Номер строки: ");
Console.WriteLine(tmp+1);

