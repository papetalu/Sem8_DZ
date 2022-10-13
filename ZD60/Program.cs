// Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Напишите программу, которая будет 
//построчно выводить массив, 
//добавляя индексы каждого элемента.
Console.Clear();
Console.WriteLine("Введите размер массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[x, y, z];

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine(" ");



void InputMatrix(int[,,] matrix)
{
   int[] array = new int[x*y*z];
   int temp;
   for (int i = 0; i < array.Length; i++)
   {
    array[i] = new Random().Next(10, 100);
    temp = array[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (array[i] == array[j])
        {
          array[i] = new Random().Next(10, 100);
          j = 0;
          temp = array[i];
        }
          temp = array[i];
      }
    }
   }

   int count = 0; 
   for (int x = 0; x < matrix.GetLength(0); x++)
   {
    for (int y = 0; y < matrix.GetLength(1); y++)
      {
      for (int z = 0; z < matrix.GetLength(2); z++)
         {
        matrix[x, y, z] = array[count];
        count++;
         }
      }
   }
}

void PrintMatrix(int[,,] inMatrix)
{
   for (int i = 0; i < inMatrix.GetLength(0); i++)
   {
      for (int j = 0; j < inMatrix.GetLength(1); j++)
      {
         for (int k = 0; k < matrix.GetLength(2); k++)
         {
            Console.Write(matrix[i, j, k] + "(" + i + "," + j + "," + k + ")" + " \t");

         }

      }

   }
}


