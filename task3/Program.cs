// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший эллемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int minValue = int.MaxValue; // переменная находит самый минимальный элемент, записываем в нее самое максимально возможное целое число
int minIndexRows = 0; // номер строчки
int minIndexColumns = 0; // номер столбца

int[,] array = new int[rows,columns];

for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    array[i,j] = new Random().Next(0,10);
    Console.Write(array[i,j] + " ");

    if (minValue > array[1,j]) // если наш данный элемент меньше чем минимальный элемент
    {
      minValue = array [i,j]; // этот элемент мы записываем в переменную
      minIndexRows = i; // номер строчки сохраняем в переменную
      minIndexColumns = j; // номер столбца сохраняем в переменную
    }
  }
  Console.WriteLine();
}

Console.WriteLine();
// выводим все наши значения
for (int i = 0; i < array.GetLength(0); i++)
{
  if (i!=minIndexRows)// если не равна, только тогда выполняется второй цикл
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (j!=minIndexColumns)
      {
        Console.Write(array[i,j] +" ");
      }
    }
  }
  
  Console.WriteLine();
}
