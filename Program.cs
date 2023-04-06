int[,] array = new int[3,4];
// Заполняем массив
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      array[i,j]=new Random().Next(0,10);
      Console.Write(array[i,j]+" ");
   }
   Console.WriteLine();
}
// Проводим сортировку
int MinSum = int.MaxValue;
int RowSum;
int MinSumRow = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
   RowSum = 0;
   for (int j = 0; j < array.GetLength(1); j++)
   {
      RowSum+=array[i,j];
   }
   if (RowSum<MinSum)
   {
      MinSum = RowSum;
      MinSumRow = i+1;
   }
}
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой: {MinSumRow}");
