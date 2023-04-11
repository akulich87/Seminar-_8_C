// Задайте двумерный массив. Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows,columns];

for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    array[i,j] = new Random().Next(0,10);
    Console.Write(array[i,j] + "\t ");
  }
  Console.WriteLine();
}

int maxIndex = array.GetLength(0) - 1; //присваиваем индекс последней строчки

for (int j = 0; j < array.GetLength(1); j++) // размер по столбцам, т.к. мы работаем с парными индексами первой и последней строки 
{                                           // один цикл так как мы работаем с одномерным массивом, числами первой и последней строки
  int temp = array[0,j]; // присваеваем новой переменной первую строку, переменная счетчик i = 1
  array[0,j] = array[maxIndex,j]; // число которое находится на последней строчке записываем в первую
  array[maxIndex,j] = temp;
}

Console.WriteLine();
// создаем 2 цикла для вывода результата

for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    Console.Write(array[i,j] + "\t ");
  }
  Console.WriteLine();
}